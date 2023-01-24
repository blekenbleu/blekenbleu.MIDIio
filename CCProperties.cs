﻿using System;
using SimHub.Plugins;

namespace blekenbleu.MIDIspace
{
    // Dynamically add events and properties for CC buttons as pressed
    // To Do: save and restore 
    public class CCProperties
    {
        internal readonly static string[] Properties = new string[128]
        {
            "CC0",
            "CC1",
            "CC2",
            "CC3",
            "CC4",
            "CC5",
            "CC6",
            "CC7",
            "CC8",
            "CC9",
            "CC10",
            "CC11",
            "CC12",
            "CC13",
            "CC14",
            "CC15",
            "CC16",
            "CC17",
            "CC18",
            "CC19",
            "CC20",
            "CC21",
            "CC22",
            "CC23",
            "CC24",
            "CC25",
            "CC26",
            "CC27",
            "CC28",
            "CC29",
            "CC30",
            "CC31",
            "CC32",
            "CC33",
            "CC34",
            "CC35",
            "CC36",
            "CC37",
            "CC38",
            "CC39",
            "CC40",
            "CC41",
            "CC42",
            "CC43",
            "CC44",
            "CC45",
            "CC46",
            "CC47",
            "CC48",
            "CC49",
            "CC50",
            "CC51",
            "CC52",
            "CC53",
            "CC54",
            "CC55",
            "CC56",
            "CC57",
            "CC58",
            "CC59",
            "CC60",
            "CC61",
            "CC62",
            "CC63",
            "CC64",
            "CC65",
            "CC66",
            "CC67",
            "CC68",
            "CC69",
            "CC70",
            "CC71",
            "CC72",
            "CC73",
            "CC74",
            "CC75",
            "CC76",
            "CC77",
            "CC78",
            "CC79",
            "CC80",
            "CC81",
            "CC82",
            "CC83",
            "CC84",
            "CC85",
            "CC86",
            "CC87",
            "CC88",
            "CC89",
            "CC90",
            "CC91",
            "CC92",
            "CC93",
            "CC94",
            "CC95",
            "CC96",
            "CC97",
            "CC98",
            "CC99",
            "CC100",
            "CC101",
            "CC102",
            "CC103",
            "CC104",
            "CC105",
            "CC106",
            "CC107",
            "CC108",
            "CC109",
            "CC110",
            "CC111",
            "CC112",
            "CC113",
            "CC114",
            "CC115",
            "CC116",
            "CC117",
            "CC118",
            "CC119",
            "CC120",
            "CC121",
            "CC122",
            "CC123",
            "CC124",
            "CC125",
            "CC126",
            "CC127"
        };
       	private Byte[] CCvalue { get; set; } = new byte[128];   // store CCvalues
        public void Init()
        {
            for (int i = 0; i < 127; i++)
                CCvalue[i] = 0;
        } 

       	internal bool SetVal(byte CCnumber, byte value)
       	{
       	    CCvalue[CCnumber] = value;
      	    return true;
       	}

        internal void SetProp(MIDIio I, byte CCnumber, byte value)
        {
            CCvalue[CCnumber] = value;
            switch (CCnumber)       // Initialize CC property and event
            {
                case 0:
                    I.AttachDelegate(Properties[0], () => CCvalue[0]);
                    I.AddEvent(Properties[0]);
                    break;
                case 1:
                    I.AttachDelegate(Properties[1], () => CCvalue[1]);
                    I.AddEvent(Properties[1]);
                    break;
                case 2:
                    I.AttachDelegate(Properties[2], () => CCvalue[2]);
                    I.AddEvent(Properties[2]);
                    break;
                case 3:
                    I.AttachDelegate(Properties[3], () => CCvalue[3]);
                    I.AddEvent(Properties[3]);
                    break;
                case 4:
                    I.AttachDelegate(Properties[4], () => CCvalue[4]);
                    I.AddEvent(Properties[4]);
                    break;
                case 5:
                    I.AttachDelegate(Properties[5], () => CCvalue[5]);
                    I.AddEvent(Properties[5]);
                    break;
                case 6:
                    I.AttachDelegate(Properties[6], () => CCvalue[6]);
                    I.AddEvent(Properties[6]);
                    break;
                case 7:
                    I.AttachDelegate(Properties[7], () => CCvalue[7]);
                    I.AddEvent(Properties[7]);
                    break;
                case 8:
                    I.AttachDelegate(Properties[8], () => CCvalue[8]);
                    I.AddEvent(Properties[8]);
                    break;
                case 9:
                    I.AttachDelegate(Properties[9], () => CCvalue[9]);
                    I.AddEvent(Properties[9]);
                    break;
                case 10:
                    I.AttachDelegate(Properties[10], () => CCvalue[10]);
                    I.AddEvent(Properties[10]);
                    break;
                case 11:
                    I.AttachDelegate(Properties[11], () => CCvalue[11]);
                    I.AddEvent(Properties[11]);
                    break;
                case 12:
                    I.AttachDelegate(Properties[12], () => CCvalue[12]);
                    I.AddEvent(Properties[12]);
                    break;
                case 13:
                    I.AttachDelegate(Properties[13], () => CCvalue[13]);
                    I.AddEvent(Properties[13]);
                    break;
                case 14:
                    I.AttachDelegate(Properties[14], () => CCvalue[14]);
                    I.AddEvent(Properties[14]);
                    break;
                case 15:
                    I.AttachDelegate(Properties[15], () => CCvalue[15]);
                    I.AddEvent(Properties[15]);
                    break;
                case 16:
                    I.AttachDelegate(Properties[16], () => CCvalue[16]);
                    I.AddEvent(Properties[16]);
                    break;
                case 17:
                    I.AttachDelegate(Properties[17], () => CCvalue[17]);
                    I.AddEvent(Properties[17]);
                    break;
                case 18:
                    I.AttachDelegate(Properties[18], () => CCvalue[18]);
                    I.AddEvent(Properties[18]);
                    break;
                case 19:
                    I.AttachDelegate(Properties[19], () => CCvalue[19]);
                    I.AddEvent(Properties[19]);
                    break;
                case 20:
                    I.AttachDelegate(Properties[20], () => CCvalue[20]);
                    I.AddEvent(Properties[20]);
                    break;
                case 21:
                    I.AttachDelegate(Properties[21], () => CCvalue[21]);
                    I.AddEvent(Properties[21]);
                    break;
                case 22:
                    I.AttachDelegate(Properties[22], () => CCvalue[22]);
                    I.AddEvent(Properties[22]);
                    break;
                case 23:
                    I.AttachDelegate(Properties[23], () => CCvalue[23]);
                    I.AddEvent(Properties[23]);
                    break;
                case 24:
                    I.AttachDelegate(Properties[24], () => CCvalue[24]);
                    I.AddEvent(Properties[24]);
                    break;
                case 25:
                    I.AttachDelegate(Properties[25], () => CCvalue[25]);
                    I.AddEvent(Properties[25]);
                    break;
                case 26:
                    I.AttachDelegate(Properties[26], () => CCvalue[26]);
                    I.AddEvent(Properties[26]);
                    break;
                case 27:
                    I.AttachDelegate(Properties[27], () => CCvalue[27]);
                    I.AddEvent(Properties[27]);
                    break;
                case 28:
                    I.AttachDelegate(Properties[28], () => CCvalue[28]);
                    I.AddEvent(Properties[28]);
                    break;
                case 29:
                    I.AttachDelegate(Properties[29], () => CCvalue[29]);
                    I.AddEvent(Properties[29]);
                    break;
                case 30:
                    I.AttachDelegate(Properties[30], () => CCvalue[30]);
                    I.AddEvent(Properties[30]);
                    break;
                case 31:
                    I.AttachDelegate(Properties[31], () => CCvalue[31]);
                    I.AddEvent(Properties[31]);
                    break;
                case 32:
                    I.AttachDelegate(Properties[32], () => CCvalue[32]);
                    I.AddEvent(Properties[32]);
                    break;
                case 33:
                    I.AttachDelegate(Properties[33], () => CCvalue[33]);
                    I.AddEvent(Properties[33]);
                    break;
                case 34:
                    I.AttachDelegate(Properties[34], () => CCvalue[34]);
                    I.AddEvent(Properties[34]);
                    break;
                case 35:
                    I.AttachDelegate(Properties[35], () => CCvalue[35]);
                    I.AddEvent(Properties[35]);
                    break;
                case 36:
                    I.AttachDelegate(Properties[36], () => CCvalue[36]);
                    I.AddEvent(Properties[36]);
                    break;
                case 37:
                    I.AttachDelegate(Properties[37], () => CCvalue[37]);
                    I.AddEvent(Properties[37]);
                    break;
                case 38:
                    I.AttachDelegate(Properties[38], () => CCvalue[38]);
                    I.AddEvent(Properties[38]);
                    break;
                case 39:
                    I.AttachDelegate(Properties[39], () => CCvalue[39]);
                    I.AddEvent(Properties[39]);
                    break;
                case 40:
                    I.AttachDelegate(Properties[40], () => CCvalue[40]);
                    I.AddEvent(Properties[40]);
                    break;
                case 41:
                    I.AttachDelegate(Properties[41], () => CCvalue[41]);
                    I.AddEvent(Properties[41]);
                    break;
                case 42:
                    I.AttachDelegate(Properties[42], () => CCvalue[42]);
                    I.AddEvent(Properties[42]);
                    break;
                case 43:
                    I.AttachDelegate(Properties[43], () => CCvalue[43]);
                    I.AddEvent(Properties[43]);
                    break;
                case 44:
                    I.AttachDelegate(Properties[44], () => CCvalue[44]);
                    I.AddEvent(Properties[44]);
                    break;
                case 45:
                    I.AttachDelegate(Properties[45], () => CCvalue[45]);
                    I.AddEvent(Properties[45]);
                    break;
                case 46:
                    I.AttachDelegate(Properties[46], () => CCvalue[46]);
                    I.AddEvent(Properties[46]);
                    break;
                case 47:
                    I.AttachDelegate(Properties[47], () => CCvalue[47]);
                    I.AddEvent(Properties[47]);
                    break;
                case 48:
                    I.AttachDelegate(Properties[48], () => CCvalue[48]);
                    I.AddEvent(Properties[48]);
                    break;
                case 49:
                    I.AttachDelegate(Properties[49], () => CCvalue[49]);
                    I.AddEvent(Properties[49]);
                    break;
                case 50:
                    I.AttachDelegate(Properties[50], () => CCvalue[50]);
                    I.AddEvent(Properties[50]);
                    break;
                case 51:
                    I.AttachDelegate(Properties[51], () => CCvalue[51]);
                    I.AddEvent(Properties[51]);
                    break;
                case 52:
                    I.AttachDelegate(Properties[52], () => CCvalue[52]);
                    I.AddEvent(Properties[52]);
                    break;
                case 53:
                    I.AttachDelegate(Properties[53], () => CCvalue[53]);
                    I.AddEvent(Properties[53]);
                    break;
                case 54:
                    I.AttachDelegate(Properties[54], () => CCvalue[54]);
                    I.AddEvent(Properties[54]);
                    break;
                case 55:
                    I.AttachDelegate(Properties[55], () => CCvalue[55]);
                    I.AddEvent(Properties[55]);
                    break;
                case 56:
                    I.AttachDelegate(Properties[56], () => CCvalue[56]);
                    I.AddEvent(Properties[56]);
                    break;
                case 57:
                    I.AttachDelegate(Properties[57], () => CCvalue[57]);
                    I.AddEvent(Properties[57]);
                    break;
                case 58:
                    I.AttachDelegate(Properties[58], () => CCvalue[58]);
                    I.AddEvent(Properties[58]);
                    break;
                case 59:
                    I.AttachDelegate(Properties[59], () => CCvalue[59]);
                    I.AddEvent(Properties[59]);
                    break;
                case 60:
                    I.AttachDelegate(Properties[60], () => CCvalue[60]);
                    I.AddEvent(Properties[60]);
                    break;
                case 61:
                    I.AttachDelegate(Properties[61], () => CCvalue[61]);
                    I.AddEvent(Properties[61]);
                    break;
                case 62:
                    I.AttachDelegate(Properties[62], () => CCvalue[62]);
                    I.AddEvent(Properties[62]);
                    break;
                case 63:
                    I.AttachDelegate(Properties[63], () => CCvalue[63]);
                    I.AddEvent(Properties[63]);
                    break;
                case 64:
                    I.AttachDelegate(Properties[64], () => CCvalue[64]);
                    I.AddEvent(Properties[64]);
                    break;
                case 65:
                    I.AttachDelegate(Properties[65], () => CCvalue[65]);
                    I.AddEvent(Properties[65]);
                    break;
                case 66:
                    I.AttachDelegate(Properties[66], () => CCvalue[66]);
                    I.AddEvent(Properties[66]);
                    break;
                case 67:
                    I.AttachDelegate(Properties[67], () => CCvalue[67]);
                    I.AddEvent(Properties[67]);
                    break;
                case 68:
                    I.AttachDelegate(Properties[68], () => CCvalue[68]);
                    I.AddEvent(Properties[68]);
                    break;
                case 69:
                    I.AttachDelegate(Properties[69], () => CCvalue[69]);
                    I.AddEvent(Properties[69]);
                    break;
                case 70:
                    I.AttachDelegate(Properties[70], () => CCvalue[70]);
                    I.AddEvent(Properties[70]);
                    break;
                case 71:
                    I.AttachDelegate(Properties[71], () => CCvalue[71]);
                    I.AddEvent(Properties[71]);
                    break;
                case 72:
                    I.AttachDelegate(Properties[72], () => CCvalue[72]);
                    I.AddEvent(Properties[72]);
                    break;
                case 73:
                    I.AttachDelegate(Properties[73], () => CCvalue[73]);
                    I.AddEvent(Properties[73]);
                    break;
                case 74:
                    I.AttachDelegate(Properties[74], () => CCvalue[74]);
                    I.AddEvent(Properties[74]);
                    break;
                case 75:
                    I.AttachDelegate(Properties[75], () => CCvalue[75]);
                    I.AddEvent(Properties[75]);
                    break;
                case 76:
                    I.AttachDelegate(Properties[76], () => CCvalue[76]);
                    I.AddEvent(Properties[76]);
                    break;
                case 77:
                    I.AttachDelegate(Properties[77], () => CCvalue[77]);
                    I.AddEvent(Properties[77]);
                    break;
                case 78:
                    I.AttachDelegate(Properties[78], () => CCvalue[78]);
                    I.AddEvent(Properties[78]);
                    break;
                case 79:
                    I.AttachDelegate(Properties[79], () => CCvalue[79]);
                    I.AddEvent(Properties[79]);
                    break;
                case 80:
                    I.AttachDelegate(Properties[80], () => CCvalue[80]);
                    I.AddEvent(Properties[80]);
                    break;
                case 81:
                    I.AttachDelegate(Properties[81], () => CCvalue[81]);
                    I.AddEvent(Properties[81]);
                    break;
                case 82:
                    I.AttachDelegate(Properties[82], () => CCvalue[82]);
                    I.AddEvent(Properties[82]);
                    break;
                case 83:
                    I.AttachDelegate(Properties[83], () => CCvalue[83]);
                    I.AddEvent(Properties[83]);
                    break;
                case 84:
                    I.AttachDelegate(Properties[84], () => CCvalue[84]);
                    I.AddEvent(Properties[84]);
                    break;
                case 85:
                    I.AttachDelegate(Properties[85], () => CCvalue[85]);
                    I.AddEvent(Properties[85]);
                    break;
                case 86:
                    I.AttachDelegate(Properties[86], () => CCvalue[86]);
                    I.AddEvent(Properties[86]);
                    break;
                case 87:
                    I.AttachDelegate(Properties[87], () => CCvalue[87]);
                    I.AddEvent(Properties[87]);
                    break;
                case 88:
                    I.AttachDelegate(Properties[88], () => CCvalue[88]);
                    I.AddEvent(Properties[88]);
                    break;
                case 89:
                    I.AttachDelegate(Properties[89], () => CCvalue[89]);
                    I.AddEvent(Properties[89]);
                    break;
                case 90:
                    I.AttachDelegate(Properties[90], () => CCvalue[90]);
                    I.AddEvent(Properties[90]);
                    break;
                case 91:
                    I.AttachDelegate(Properties[91], () => CCvalue[91]);
                    I.AddEvent(Properties[91]);
                    break;
                case 92:
                    I.AttachDelegate(Properties[92], () => CCvalue[92]);
                    I.AddEvent(Properties[92]);
                    break;
                case 93:
                    I.AttachDelegate(Properties[93], () => CCvalue[93]);
                    I.AddEvent(Properties[93]);
                    break;
                case 94:
                    I.AttachDelegate(Properties[94], () => CCvalue[94]);
                    I.AddEvent(Properties[94]);
                    break;
                case 95:
                    I.AttachDelegate(Properties[95], () => CCvalue[95]);
                    I.AddEvent(Properties[95]);
                    break;
                case 96:
                    I.AttachDelegate(Properties[96], () => CCvalue[96]);
                    I.AddEvent(Properties[96]);
                    break;
                case 97:
                    I.AttachDelegate(Properties[97], () => CCvalue[97]);
                    I.AddEvent(Properties[97]);
                    break;
                case 98:
                    I.AttachDelegate(Properties[98], () => CCvalue[98]);
                    I.AddEvent(Properties[98]);
                    break;
                case 99:
                    I.AttachDelegate(Properties[99], () => CCvalue[99]);
                    I.AddEvent(Properties[99]);
                    break;
                case 100:
                    I.AttachDelegate(Properties[100], () => CCvalue[100]);
                    I.AddEvent(Properties[100]);
                    break;
                case 101:
                    I.AttachDelegate(Properties[101], () => CCvalue[101]);
                    I.AddEvent(Properties[101]);
                    break;
                case 102:
                    I.AttachDelegate(Properties[102], () => CCvalue[102]);
                    I.AddEvent(Properties[102]);
                    break;
                case 103:
                    I.AttachDelegate(Properties[103], () => CCvalue[103]);
                    I.AddEvent(Properties[103]);
                    break;
                case 104:
                    I.AttachDelegate(Properties[104], () => CCvalue[104]);
                    I.AddEvent(Properties[104]);
                    break;
                case 105:
                    I.AttachDelegate(Properties[105], () => CCvalue[105]);
                    I.AddEvent(Properties[105]);
                    break;
                case 106:
                    I.AttachDelegate(Properties[106], () => CCvalue[106]);
                    I.AddEvent(Properties[106]);
                    break;
                case 107:
                    I.AttachDelegate(Properties[107], () => CCvalue[107]);
                    I.AddEvent(Properties[107]);
                    break;
                case 108:
                    I.AttachDelegate(Properties[108], () => CCvalue[108]);
                    I.AddEvent(Properties[108]);
                    break;
                case 109:
                    I.AttachDelegate(Properties[109], () => CCvalue[109]);
                    I.AddEvent(Properties[109]);
                    break;
                case 110:
                    I.AttachDelegate(Properties[110], () => CCvalue[110]);
                    I.AddEvent(Properties[110]);
                    break;
                case 111:
                    I.AttachDelegate(Properties[111], () => CCvalue[111]);
                    I.AddEvent(Properties[111]);
                    break;
                case 112:
                    I.AttachDelegate(Properties[112], () => CCvalue[112]);
                    I.AddEvent(Properties[112]);
                    break;
                case 113:
                    I.AttachDelegate(Properties[113], () => CCvalue[113]);
                    I.AddEvent(Properties[113]);
                    break;
                case 114:
                    I.AttachDelegate(Properties[114], () => CCvalue[114]);
                    I.AddEvent(Properties[114]);
                    break;
                case 115:
                    I.AttachDelegate(Properties[115], () => CCvalue[115]);
                    I.AddEvent(Properties[115]);
                    break;
                case 116:
                    I.AttachDelegate(Properties[116], () => CCvalue[116]);
                    I.AddEvent(Properties[116]);
                    break;
                case 117:
                    I.AttachDelegate(Properties[117], () => CCvalue[117]);
                    I.AddEvent(Properties[117]);
                    break;
                case 118:
                    I.AttachDelegate(Properties[118], () => CCvalue[118]);
                    I.AddEvent(Properties[118]);
                    break;
                case 119:
                    I.AttachDelegate(Properties[119], () => CCvalue[119]);
                    I.AddEvent(Properties[119]);
                    break;
                case 120:
                    I.AttachDelegate(Properties[120], () => CCvalue[120]);
                    I.AddEvent(Properties[120]);
                    break;
                case 121:
                    I.AttachDelegate(Properties[121], () => CCvalue[121]);
                    I.AddEvent(Properties[121]);
                    break;
                case 122:
                    I.AttachDelegate(Properties[122], () => CCvalue[122]);
                    I.AddEvent(Properties[122]);
                    break;
                case 123:
                    I.AttachDelegate(Properties[123], () => CCvalue[123]);
                    I.AddEvent(Properties[123]);
                    break;
                case 124:
                    I.AttachDelegate(Properties[124], () => CCvalue[124]);
                    I.AddEvent(Properties[124]);
                    break;
                case 125:
                    I.AttachDelegate(Properties[125], () => CCvalue[125]);
                    I.AddEvent(Properties[125]);
                    break;
                case 126:
                    I.AttachDelegate(Properties[126], () => CCvalue[126]);
                    I.AddEvent(Properties[126]);
                    break;
                case 127:
                    I.AttachDelegate(Properties[127], () => CCvalue[127]);
                    I.AddEvent(Properties[127]);
                    break;
                default:
                    SimHub.Logging.Current.Info($"SetProp() not set: CC{CCnumber}");
                    break;
            }
            if (0 < value)
                I.TriggerEvent(Properties[CCnumber]);
        }
    }
}
