﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA6EC1041FE8F1AF9, SubGUID = 0xE4AFCD52DEB8A62F)]
    public class GcGalaxyStarColours : NMSTemplate      // size: 0x40
    {
        [NMS(Size = 0x4, EnumValue = new[] { "Yellow", "Green", "Blue", "Red" })]
        public Colour[] ColourByStarType;
    }
}
