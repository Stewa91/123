using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ShadowyEffect, HasIndexInData = false)]
    public class ShadowyEffectEntry
    {
        public uint PrimaryColor { get; set; }
        public uint SecondaryColor { get; set; }
        public float Duration { get; set; }
        public float Value { get; set; }
        public float FadeInTime { get; set; }
        public float FadeOutTime { get; set; }
        public byte AttachPos { get; set; }
        public byte Flags { get; set; }
        public float InnerStrength { get; set; }
        public float OuterStrength { get; set; }
        public float InitialDelay { get; set; }
        public int CurveId { get; set; }
        public uint Priority { get; set; }
    }
}