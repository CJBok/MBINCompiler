﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3E0, GUID = 0x4408162C9D554F85)]
    public class GcProductData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMS(Size = 0x80)]
        /* 0x010 */ public string Name;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string NameLower;
        /* 0x110 */ public VariableSizeString Subtitle;
        /* 0x120 */ public VariableSizeString Description;
        [NMS(Size = 0x20)]
        /* 0x130 */ public string Hint;
        [NMS(Size = 0x10)]
        /* 0x150 */ public string GroupID;
        /* 0x160 */ public TkModelResource DebrisFile;
        /* 0x1E4 */ public int BaseValue;
        /* 0x1E8 */ public int Level;
        /* 0x1EC */ public TkModelResource Icon;
        /* 0x270 */ public TkModelResource HeroIcon;
        /* 0x300 */ public Colour Colour;
        /* 0x310 */ public GcRealitySubstanceCategory SubstanceCategory;
        /* 0x314 */ public GcProductCategory Type;
        /* 0x318 */ public GcRarity Rarity;
        /* 0x31C */ public GcLegality Legality;
        /* 0x320 */ public bool Consumable;
        /* 0x324 */ public int ChargeValue;
        /* 0x328 */ public int StackMultiplier;
        /* 0x32C */ public int DefaultCraftAmount;
        /* 0x330 */ public int CraftAmountStepSize;
        /* 0x334 */ public int CraftAmountMultiplier;
        /* 0x338 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x348 */ public List<GcTechnologyRequirement> AltRequirements;
        /* 0x358 */ public GcItemPriceModifiers Cost;
        /* 0x36C */ public bool SpecificChargeOnly;
        /* 0x370 */ public float NormalisedValueOnWorld;
        /* 0x374 */ public float NormalisedValueOffWorld;
        /* 0x378 */ public GcTradeCategory TradeCategory;
        /* 0x37C */ public bool WikiEnabled;
        /* 0x37D */ public bool IsCraftable;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x37E */ public byte[] Padding37E;
        [NMS(Size = 0x10)]
        /* 0x380 */ public string DeploysInto;
        /* 0x390 */ public float EconomyInfluenceMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x394 */ public byte[] Padding39C;
        [NMS(Size = 0x20)]
        /* 0x398 */ public string PinObjeective;
        [NMS(Size = 0x20)]
        /* 0x3B8 */ public string PinObjeectiveTip;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x3D8 */ public byte[] EndPadding;
    }
}
