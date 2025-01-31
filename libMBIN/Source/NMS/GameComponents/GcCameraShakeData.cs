﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC0, GUID = 0x2BDD0C90F80F5BE7, SubGUID = 0x381A76E400DE3EE7)]
    public class GcCameraShakeData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;

        /* 0x10 */ public float TimeStart;
        /* 0x14 */ public float TotalTime;
        /* 0x18 */ public float DecayRate;
        /* 0x1C */ public float StrengthSale;
        /* 0x20 */ public float ThirdPersonDamp;

        /* 0x24 */ public GcCameraShakeCapturedData CapturedData;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x38 */ public byte[] Padding38;

       /* 0x40 */  public GcCameraShakeMechanicalData MechanicalData;

        /* 0xB0 */ public float FOVStrength;
        /* 0xB4 */ public float FOVFrequency;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0xB8 */ public byte[] EndPadding;
    }
}
