﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x1AA0E0DA0E623F9D)]
    public class GcSkyGlobals : NMSTemplate
    {
        /* 0x0000 */ public float RainbowDistance;
        /* 0x0004 */ public float RainbowScale;
        /* 0x0008 */ public float RainbowWidth;
        /* 0x000C */ public float RainbowAlpha;
        /* 0x0010 */ public float RainbowStormAlpha;
        /* 0x0014 */ public float RainbowFadeWidth;
        /* 0x0018 */ public float NightThreshold;
        /* 0x001C */ public GcPhotoModeAdjustData FogAdjust;
        /* 0x0034 */ public GcPhotoModeAdjustData CloudAdjust;
        /* 0x004C */ public GcPhotoModeAdjustData VignetteAdjust;
        /* 0x0064 */ public TkCurveType DoFAdjustMagnitudeMaxCurve;
        /* 0x0068 */ public int DayLength;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x006C */ public byte[] Padding6D;
        /* 0x0070 */ public Vector4f SunRotationAxis;
        /* 0x0080 */ public int SafeSkyMinIndex;
        /* 0x0084 */ public int SafeSkyMaxIndex;
        /* 0x0088 */ public int FrozenSkyMinIndex;
        /* 0x008C */ public int FrozenSkyMaxIndex;
        /* 0x0090 */ public float SunClampAngle;
        /* 0x0094 */ public float PhotoModeSunSpeed;
        /* 0x0098 */ public float FreshStartTimeOfDay;
        /* 0x009C */ public bool ForceStormSetting;
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x009D */ public byte[] Padding9D;
        /* 0x00A0 */ public float ForceStormStrength;
        /* 0x00A4 */ public float StormScreenFilterFadeTime;
        /* 0x00A8 */ public float StormScreenFilterDistance;
        /* 0x00AC */ public float MinTimeBetweenStormsLow;
        /* 0x00B0 */ public float MaxTimeBetweenStormsLow;
        /* 0x00B4 */ public float MinTimeBetweenStormsHigh;
        /* 0x00B8 */ public float MaxTimeBetweenStormsHigh;
        /* 0x00BC */ public float MinTimeBetweenStormsExtremeFallback;
        /* 0x00C0 */ public float MaxTimeBetweenStormsExtremeFallback;
        /* 0x00C4 */ public float MinStormLengthLow;
        /* 0x00C8 */ public float MaxStormLengthLow;
        /* 0x00CC */ public float MinStormLengthHigh;
        /* 0x00D0 */ public float MaxStormLengthHigh;
        /* 0x00D4 */ public float StormWarningTime;
        /* 0x00D8 */ public float StormTransitionTime;
        /* 0x00DC */ public bool ForceFlightSetting;
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x00DD */ public byte[] PaddingDD;
        /* 0x00E0 */ public float ForceFlightStrength;
        /* 0x00E4 */ public float ToFootFadeTime;
        /* 0x00E8 */ public float ToFlightFadeTime;
        /* 0x00EC */ public float InFlightStormStrength;
        /* 0x00F0 */ public float CreatureStormThreshold;
        /* 0x00F4 */ public float TakeoffStormThreshold;
        /* 0x00F8 */ public float ExtremeAudioLevel;
        /* 0x00FC */ public float StormAudioLevel;
        /* 0x0100 */ public bool SleepSunFromSettings;
        [NMS(Size = 0x0F, Ignore = true)]
        /* 0x0101 */ public byte[] Padding101;
        /* 0x0110 */ public Vector4f SleepSunFromSettingsPos;
        /* 0x0120 */ public Vector4f SunPosition;
        /* 0x0130 */ public Colour AsteroidColour;
        /* 0x0140 */ public Colour DayLightColour;
        /* 0x0150 */ public Colour NightLightColour;
        /* 0x0160 */ public Colour DuskLightColour;
        /* 0x0170 */ public Colour NightHeavyAirColour;
        /* 0x0180 */ public Colour SpaceLightColour;
        /* 0x0190 */ public float HeavyAirScale;
        /* 0x0194 */ public float AmbientFactor;
        /* 0x0198 */ public float MinSunsetFade;
        /* 0x019C */ public float MaxSunsetFade;
        /* 0x01A0 */ public float MinSunsetHorizonFade;
        /* 0x01A4 */ public float MaxSunsetHorizonFade;
        /* 0x01A8 */ public float MinNightFade;
        /* 0x01AC */ public float MaxNightFade;
        /* 0x01B0 */ public float MinSunsetPosFade;
        /* 0x01B4 */ public float MaxSunsetPosFade;
        /* 0x01B8 */ public float MinSunsetFogFade;
        /* 0x01BC */ public float MaxSunsetFogFade;
        /* 0x01C0 */ public float MinSunsetAtmosphereFade;
        /* 0x01C4 */ public float MaxSunsetAtmosphereFade;
        /* 0x01C8 */ public float MinSunsetColourFade;
        /* 0x01CC */ public float MaxSunsetColourFade;
        /* 0x01D0 */ public float MinSaturation;
        /* 0x01D4 */ public float MaxSaturation;
        /* 0x01D8 */ public float MinValue;
        /* 0x01DC */ public float MaxValue;
        /* 0x01E0 */ public float MinFogSaturation;
        /* 0x01E4 */ public float MaxFogSaturation;
        /* 0x01E8 */ public float MinFogValue;
        /* 0x01EC */ public float MaxFogValue;
        /* 0x01F0 */ public float MinColourS;
        /* 0x01F4 */ public float MaxColourS;
        /* 0x01F8 */ public float MinColourV;
        /* 0x01FC */ public float MaxColourV;
        /* 0x0200 */ public float MulticolourH;
        /* 0x0204 */ public float NebulaColourH;
        /* 0x0208 */ public float NebulaColour1S;
        /* 0x020C */ public float NebulaColour1V;
        /* 0x0210 */ public float NebulaColour2S;
        /* 0x0214 */ public float NebulaColour2V;
        /* 0x0218 */ public float MidColourH;
        /* 0x021C */ public float MidColourS;
        /* 0x0220 */ public float MidColourV;
        /* 0x0224 */ public float CloudColourH;
        /* 0x0228 */ public float CloudColourS;
        /* 0x022C */ public float CloudColourV;
        /* 0x0230 */ public float NebulaShadow;
        /* 0x0234 */ public float SpaceAtmosphereThickness;
        /* 0x0238 */ public float WaterHeavyAirAlpha;
        /* 0x023C */ public float NightHorizonBlendMin;
        /* 0x0240 */ public float NightHorizonBlendMax;
        /* 0x0244 */ public float NightSkyBlendMin;
        /* 0x0248 */ public float NightSkyBlendMax;
        /* 0x024C */ public float NightLightBlendMin;
        /* 0x0250 */ public float NightLightBlendMax;
        /* 0x0254 */ public bool ForceNightBlend;
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x0255 */ public byte[] Padding255;
        /* 0x0258 */ public float ForceNightBlendValue;
        /* 0x025C */ public float NoAtmosphereFogStrength;
        /* 0x0260 */ public float NoAtmosphereFogMax;
        /* 0x0264 */ public float NoAtmosphereColourStrength;
        /* 0x0268 */ public float NoAtmosphereColourMax;
        /* 0x026C */ public float LowFlightFogThreshold;
        /* 0x0270 */ public GcSkyProperties PlanetSky;
        /* 0x02A0 */ public GcFogProperties PlanetFog;
        /* 0x037C */ public GcFogProperties PlanetExtremeFog;
        /* 0x0458 */ public GcFogProperties PlanetStormFog;
        /* 0x0534 */ public GcFogProperties PlanetFlightFog;
        /* 0x0610 */ public GcSpaceSkyProperties SpaceSkyMin;
        /* 0x06B0 */ public GcSpaceSkyProperties SpaceSkyMax;
        [NMS(Size = 0x04)]
        /* 0x0750 */ public GcSpaceSkyColours[] SpaceSkyColours;
        /* 0x0AD0 */ public GcPlanetWeatherColourData NightSkyColours;
        /* 0x0B80 */ public float HackSpaceInterp1;
        /* 0x0B84 */ public float HackSpaceInterp2;
        /* 0x0B88 */ public int HackSpaceColourIndex;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x0B8C */ public byte[] PaddingB8C;
        /* 0x0B90 */ public Colour HeavyAirColour1;
        /* 0x0BA0 */ public Colour HeavyAirColour2;
        /* 0x0BB0 */ public Colour NightHorizonColour;
        /* 0x0BC0 */ public Colour NightSkyColour;
        /* 0x0BD0 */ public Colour NightFogColour;
        /* 0x0BE0 */ public Colour NightHeightFogColour;
        /* 0x0BF0 */ public GcPlanetCloudProperties PlanetCloudsMin;
        /* 0x0C18 */ public GcPlanetCloudProperties PlanetCloudsMax;
    }
}
