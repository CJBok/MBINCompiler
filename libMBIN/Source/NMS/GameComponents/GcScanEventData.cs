﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2E8, Alignment = 0x8, GUID = 0x19CA42A5DC5D6E50, SubGUID = 0x7BBBCE7D7BC0F1F4)]
    public class GcScanEventData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string ForceInteraction;
        /* 0x040 */ public GcInteractionType ForceInteractionType;
        /* 0x044 */ public bool ForceBroken;
        /* 0x045 */ public bool ForceFixed;
        /* 0x046 */ public bool ForceOverridesAll;
        /* 0x047 */ public bool IsCommunityPortalOverride;
        /* 0x048 */ public bool ClearForcedInteractionOnCompletion;
        /* 0x049 */ public bool AlwaysShow;
        /* 0x04A */ public bool NeverShow;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x04B */ public byte[] Padding4B;
        [NMS(Size = 0x20)]
        /* 0x050 */ public string PlanetLabelText;

        public enum EventStartTypeEnum { None, Special, Discovered, Timer, ObjectScan, LeaveBuilding }
		/* 0x070 */ public EventStartTypeEnum EventStartType;
		public enum EventEndTypeEnum { None, Proximity, Interact, EnterBuilding, TimedInteract }
		/* 0x074 */ public EventEndTypeEnum EventEndType;
		public enum EventPriorityEnum { Regular, High }
		/* 0x078 */ public EventPriorityEnum EventPriority;

        /* 0x07C */ public bool CanEndFromOutsideMission;
        /* 0x07D */ public bool DisableMultiplayerSync;
        /* 0x07E */ public bool ReplaceEventIfAlreadyActive;

        public enum BuildingLocationEnum { Nearest, AllNearest, Random, RandomOnNearPlanet, RandomOnFarPlanet, PlanetSearch }
		/* 0x080 */ public BuildingLocationEnum BuildingLocation;
		public enum BuildingTypeEnum { Any, AnyShelter, AnyNPC, BuildingClass, SpaceStation, SpaceAnomaly, Atlas, Freighter, FreighterBase,
            ExternalPlanetBase, PlanetBaseTerminal, Expedition, TutorialShelter, MPMissionFreighter, Nexus, InitialDistressSignal }
		/* 0x084 */ public BuildingTypeEnum BuildingType;
        /* 0x088 */ public GcBuildingClassification BuildingClass;
        /* 0x08C */ public bool AllowFriendBases;

		public enum SolarSystemLocationEnum { Local, Near, LocalOrNear, NearWithNoExpeditions, FromList }
		/* 0x090 */ public SolarSystemLocationEnum SolarSystemLocation;

        /* 0x098 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        /* 0x0F8 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        /* 0x158 */ public bool ForceRestartInteraction;
        [NMS(Size = 7, Ignore = true)]
        /* 0x159 */ public byte[] Padding159;
        [NMS(Size = 0x10)]
        /* 0x160 */ public string HasReward;
        [NMS(Size = 0x20)]
        /* 0x170 */ public string NextOption;
        /* 0x190 */ public GcScanEventTriggers TriggerActions;
        /* 0x1B0 */ public List<NMSString0x100> UAsList;
        /* 0x1C0 */ public GcTechnologyCategory TechShopType;
        [NMS(Size = 0x20)]
        /* 0x1C4 */ public string OSDMessage;
        [NMS(Size = 0x20)]
        /* 0x1E4 */ public string InterstellarOSDMessage;
        [NMS(Size = 0x20)]
        /* 0x204 */ public string MarkerLabel;
        /* 0x224 */ public TkTextureResource MarkerIcon;
        /* 0x2A8 */ public float StartTime;
        /* 0x2AC */ public float MessageTime;
        /* 0x2B0 */ public float MessageDisplayTime;
        /* 0x2B4 */ public GcAudioWwiseEvents MessageAudio;
        /* 0x2B8 */ public float IconTime;
        /* 0x2BC */ public float TooltipTime;
        /* 0x2C0 */ public bool TooltipRepeats;
        /* 0x2C1 */ public bool ShowEndTooltip;
        [NMS(Size = 0x20)]
        /* 0x2C2 */ public string TooltipMessage;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x2D2 */ public byte[] EndPadding;
    }
}