using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BeamEffect, HasIndexInData = false)]
    public class BeamEffectEntry
    {
        public int BeamId { get; set; }
        public float SourceMinDistance { get; set; }
        public float FixedLength { get; set; }
        public int Flags { get; set; }
        public int SourceOffset { get; set; }
        public int DestOffset { get; set; }
        public int SourceAttachId { get; set; }
        public int DestAttachId { get; set; }
        public int SourcePositionerId { get; set; }
        public int DestPositionerId { get; set; }
    }
}