### blekenbleu.MIDIio SimHub plugin source code files (C# classes)
- [MIDIio.cs](../MIDIio.cs) class is the SimHub plugin equivalent of main().   
  It interfaces other classes to SimHub, handling properties, events, actions, initializations and cleanups.  
- [MIDIioSettings.cs](../MIDIioSettings.cs) is *only* data to be saved and restored between plugin launches.  
- [CCProperties.cs](../CCProperties.cs) initializes properties for MIDIio.cs.  
- [INdrywet.cs](../INdrywet.cs) handles MIDI messages from `MIDIin`
  using [Melanchall.DryWetMidi](https://github.com/melanchall/drywetmidi)  
- [OUTdrywet.cs](../OUTdrywet.cs) sends MIDI messages to `MIDIout`.  
- [VJsend.cs](../VJsend.cs) sends button and axis values to a single vJoy device.
- [VJoyFFBReceiver.cs](../VJoyFFBReceiver.cs) placeholder code for handling vJoy force feedback data.
- (*Not* a class);  [MIDIio.ini](../MIDIio.ini) contains NCalc properties to configure **MIDIio**.  
  It goes in `SimHub/NCalcScripts/`;&nbsp;  contents include:
  - `MIDIin`:        name of source MIDI device
  - `MIDIout`:       name of destination MIDI device
  - `MIDIsliders`:   MIDI CC numbers `n` whose values are to be set as `slidern` properties.  
  - `MIDIknobs`:     MIDI CC numbers `n` whose values are to be set as `knobn` properties,  
                     handled identically to `MIDIsliders`  
  - `MIDIbuttons`:   MIDI CC numbers `n` to be set as `CCn` properties and, when (values > 0), also raise events.  
  - `MIDIsendn`:     name of e.g. a ShakeIt property whose value *changes* are sent to `MIDIout`  
                      as `CCn` messages for `0 <= n < 8`.  
                     A `pingn` action will be enabled for each configured `MIDIsendn`.  
                     By mapping a `CC` **Source** to a `pingn` **Target** in SimHub's **Controls and events**,  
                     the corresponding `MIDIin` device button can be used
                     to help identify that `CCn` to a `MIDIout` application.  
  - `MIDIecho`:      if `0` or not defined, all received CC values `n` not otherwised configured  
                     (in `MIDIsliders`, `MIDIknobs` or `MIDIbuttons`) are automatically created as `CCn` properties,  
                     else (`MIDIecho > 0`) unconfigured MIDI messages are forwarded from `MIDIin` to `MIDIout`.
  - `MIDIlog`        Controls MIDIio's **System Log** verbosity;&nbsp; 0 is mostly only errors and 15 is maximally verbose.  
  - `MIDIsize`	     Limits routing table size between game, vJoy and MIDI
  - `MIDICCsends`    Index array of configured `MIDICCsendn`, where 0 <= n < 128
  - `MIDIvJDbuttons` Index array of configured `MIDIvJDbuttonb`, where 1 <= v <= (16) Buttons
                     as reported by `MIDIio.VJsend.Init() in the ** System Log**
  - `MIDIvJDaxiss`   Index array of configured `MIDIvJDaxiss`, where 0 <= s < (8) Axes
                     as reported by `MIDIio.VJsend.Init()` in the ** System Log**  

`MIDIecho 1` forwards unconfigured `MIDIin` CC changed messages to `MIDIout`.  
Un-echoed CC messages most recently sent to `MIDIout` are saved,  
then resent when SimHub next launches the MIDIio plugin.  
This is intended to enable resuming a MIDI configuration from time to time.  
Duplicated send CC messages are NOT sent, to minimize traffic and CPU overhead.  
In `MIDIecho 1` mode, only previously configured input and output properties may be used.  
In `MIDIecho 0` mode, SimHub properties are dynamically generated for unconfigured input CC numbers, but not forwarded.  
This allows learning MIDI controller CC numbers (by checking SimHUb's **Property** window),  
for adding to `SimHub/NCalcScripts/MIDIio.ini`.  

Here is some evidence of operational success (*26 Jan 2023*):  
- **[MidiView](https://hautetechnique.com/midi/midiview/) trace screen**:  
![](MidiView.png)  

- ... for this game replay:  
![](replay.png)  

- which was prior to vJoy implementation.  

 *updated 23 Feb 2023 for vJoy*  
