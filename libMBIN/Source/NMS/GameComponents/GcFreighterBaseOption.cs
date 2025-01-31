﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x84, GUID = 0xEFADC778D8A5950B, SubGUID = 0x27F9FF00242DF25A)]
    public class GcFreighterBaseOption : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string BaseDataFile;
        public float ProbabilityWeighting;
    }
}
