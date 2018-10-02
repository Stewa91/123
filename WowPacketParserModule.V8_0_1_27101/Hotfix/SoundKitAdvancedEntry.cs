using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SoundKitAdvanced)]
    public class SoundKitAdvancedEntry
    {
        public int ID { get; set; }
        public int SoundKitId { get; set; }
        public float InnerRadius2D { get; set; }
        public float OuterRadius2D { get; set; }
        public int TimeA { get; set; }
        public int TimeB { get; set; }
        public int TimeC { get; set; }
        public int TimeD { get; set; }
        public int RandomOffsetRange { get; set; }
        public byte Usage { get; set; }
        public int TimeIntervalMin { get; set; }
        public int TimeIntervalMax { get; set; }
        public int DelayMin { get; set; }
        public int DelayMax { get; set; }
        public byte VolumeSliderCategory { get; set; }
        public float DuckToAmbience { get; set; }
        public float DuckToDialog { get; set; }
        public float DuckToSuppressors { get; set; }
        public float DuckToSFX { get; set; }
        public float DuckToMusic { get; set; }
        public float InnerRadiusOfInfluence { get; set; }
        public float OuterRadiusOfInfluence { get; set; }
        public int TimeToDuck { get; set; }
        public int TimeToUnduck { get; set; }
        public float InsideAngle { get; set; }
        public float OutsideAngle { get; set; }
        public float OutsideVolume { get; set; }
        public byte MinRandomPosOffset { get; set; }
        public ushort MaxRandomPosOffset { get; set; }
        public int MsOffset { get; set; }
        public int TimeCooldownMin { get; set; }
        public int TimeCooldownMax { get; set; }
        public byte MaxInstancesBehavior { get; set; }
        public byte VolumeControlType { get; set; }
        public int VolumeFadeInTimeMin { get; set; }
        public int VolumeFadeInTimeMax { get; set; }
        public int VolumeFadeInCurveId { get; set; }
        public int VolumeFadeOutTimeMin { get; set; }
        public int VolumeFadeOutTimeMax { get; set; }
        public int VolumeFadeOutCurveId { get; set; }
        public float ChanceToPlay { get; set; }
    }
}