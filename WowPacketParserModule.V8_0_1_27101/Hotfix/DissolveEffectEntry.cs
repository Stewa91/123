using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.DissolveEffect, HasIndexInData = false)]
    public class DissolveEffectEntry
    {
        public float Ramp { get; set; }
        public float StartValue { get; set; }
        public float EndValue { get; set; }
        public float FadeInTime { get; set; }
        public float FadeOutTime { get; set; }
        public float Duration { get; set; }
        public byte AttachId { get; set; }
        public byte ProjectionType { get; set; }
        public int TextureBlendSetId { get; set; }
        public float Scale { get; set; }
        public int Flags { get; set; }
        public int CurveId { get; set; }
        public uint Priority { get; set; }
        public float FresnelIntensity { get; set; }
    }
}