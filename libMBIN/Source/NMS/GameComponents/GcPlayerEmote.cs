﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x128, GUID = 0xAF5616FFEC6C1D13)]
    public class GcPlayerEmote : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string ChatText;
        [NMS(Size = 0x10)]
        /* 0x040 */ public string AnimationName;

        /* 0x050 */ public TkTextureResource Icon;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0D4 */ public byte[] PaddingD4;
        
        [NMS(Size = 0x10)]
        /* 0x0D8 */ public string LinkedSpecialID;
        [NMS(Size = 0x10)]
        /* 0x0E8 */ public string LoopAnimUntilMov;

        /* 0x0F8 */ public bool CloseMenuOnSelect;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x0F9 */ public byte[] PaddingF9;

        [NMS(Size = 0x10)]
        /* 0x100 */ public string GekAnimationName;
        [NMS(Size = 0x10)]
        /* 0x110 */ public string GekLoopAnimUntilMove;

        /* 0x120 */ public bool AvailableUnderwater;

        [NMS(Size = 0x7, Ignore = true)]
        /* 0x121 */ public byte[] Endpadding;
    }
}
