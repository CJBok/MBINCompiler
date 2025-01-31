﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x88, GUID = 0x5CF50411F86F56C9, SubGUID = 0xE62B86A237CB0756)]
    public class GcMissionSequenceCloseMenu : NMSTemplate
    {
        public float Delay;
        public enum MenuToCloseEnum { QuickMenu, BuildMenu, Inventory, AllDetailMessages }
        public MenuToCloseEnum MenuToClose;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
