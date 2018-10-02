using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.EdgeGlowEffect, HasIndexInData = false)]
    public class EdgeGlowEffectEntry
    {
        public float Duration { get; set; }
        public float FadeIn { get; set; }
        public float FadeOut { get; set; }
        public float FresnelCoefficient { get; set; }
        public float GlowRed { get; set; }
        public float GlowGreen { get; set; }
        public float GlowBlue { get; set; }
        public float GlowAlpha { get; set; }
        public float GlowMultiplier { get; set; }
        public byte Flags { get; set; }
        public float InitialDelay { get; set; }
        public int CurveId { get; set; }
        public int Priority { get; set; }
    }
}