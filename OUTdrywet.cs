﻿using System;
using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Devices;
using SimHub.Plugins;

namespace blekenbleu.MIDIspace
{
    /// <summary>
    /// from Output device https://melanchall.github.io/drywetmidi/articles/devices/Output-device.html
    /// </summary>
    internal class OUTdrywet
    {
        private static IOutputDevice _outputDevice;
        private static IOutputDevice OutputDevice { get => _outputDevice; set => _outputDevice = value; }
        private MIDIioSettings Settings;
        private bool Connected;
        private byte val = 63;
        private String CCout;       // Output MIDI destination

        private void SendCC(byte control, byte value)
        {   // wasted a day not finding this documented
            OutputDevice.SendEvent(new ControlChangeEvent((SevenBitNumber)control, (SevenBitNumber)value));
        }

        internal bool Ping(SevenBitNumber num) // gets called (indirectly, event->action) by INdrywet()
        {
            if (Connected) {
                SendCC(num, val);
                SimHub.Logging.Current.Info($"{CCout} CC{num} pinged {val}");
                val = (byte)((63 == val) ? 127 : 63);
                return true;
            }
            else SimHub.Logging.Current.Info($"{CCout} disabled");
            return false;
        }

        internal bool SendProp(byte i, byte input)
        {
            if (Connected)
            {
                SendCC(i, input);
                return true;
            }
            else return false;
        }

        internal void Init(String MIDIout, MIDIioSettings savedSettings)
        {
            CCout = MIDIout;
            Connected = true;       	// assume the best
            Settings = savedSettings;	// Loaded settings
            try
            {
                OutputDevice = Melanchall.DryWetMidi.Devices.OutputDevice.GetByName(MIDIout);
                OutputDevice.EventSent += OnEventSent;
                OutputDevice.PrepareForEventsSending();
                SimHub.Logging.Current.Info($"MIDIio OUTdrywet output is ready to send {MIDIout} messages.");
                // resend saved CCs
                for (byte i = 0; i < 8; i++)
                    SendCC(i, Settings.Sent[i]);    // time may have passed;  reinitialize MIDI destination
            }
            
            catch (Exception)
            {
                Connected = false;
                SimHub.Logging.Current.Info($"Failed to find OUTdrywet output device {MIDIout};\nKnown devices:");
                foreach (var outputDevice in Melanchall.DryWetMidi.Devices.OutputDevice.GetAll())
                    SimHub.Logging.Current.Info(outputDevice.Name);
            }
        }

        internal void End()
        {
            (_outputDevice as IDisposable)?.Dispose();
        }

        // callback
        void OnEventSent(object sender, MidiEventSentEventArgs e)
        {
            var midiDevice = (MidiDevice)sender;
            // this cute syntax is called pattern matching
            if (Connected && e.Event is ControlChangeEvent foo)
            {
//              SimHub.Logging.Current.Info($"ControlNumber = {foo.ControlNumber}; ControlValue = {foo.ControlValue}");
                if (7 < foo.ControlNumber)	// unsigned
                    SimHub.Logging.Current.Info($"Mystery {CCout} ControlChangeEvent : {foo}");
            }
            else SimHub.Logging.Current.Info($"Ignoring {midiDevice.Name} {e.Event} reported for {CCout}");
        }
    }
}