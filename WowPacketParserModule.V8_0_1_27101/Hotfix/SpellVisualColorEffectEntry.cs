using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellVisualColorEffect, HasIndexInData = false)]
    public class SpellVisualColorEffectEntry
    {
        public float Duration { get; set; }
        public uint Color { get; set; }
        public byte Flags { get; set; }
        public byte Type { get; set; }
        public ushort RedCurveId { get; set; }
        public ushort GreenCurveId { get; set; }
        public ushort BlueCurveId { get; set; }
        public ushort AlphaCurveId { get; set; }
        public ushort OpacityCurveId { get; set; }
        public float ColorMultiplier { get; set; }
        public uint PositionerId { get; set; }
    }
}