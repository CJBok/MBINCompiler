﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x27B4FEC32B042806, SubGUID = 0xBC8B5F2250F65891)]
    public class GcShipDialogueTreeEnum : NMSTemplate
    {
		public enum DialogueTreeEnum { Bribe, Beg, Ambush, Trade, Help, Goods, Hostile }
		public DialogueTreeEnum DialogueTree;
    }
}
