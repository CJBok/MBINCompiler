﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8C, GUID = 0x8D124FD3F031C94C, SubGUID = 0x8EEA012026874C5C)]
    public class GcObjectSpawnerComponentData : NMSTemplate
    {
        public TkTextureResource Object;
        public int SpawnPowerCost;
        public float SpawnCooldown;
    }
}
