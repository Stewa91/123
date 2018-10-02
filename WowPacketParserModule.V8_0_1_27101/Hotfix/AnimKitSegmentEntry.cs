using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AnimKitSegment, HasIndexInData = false)]
    public class AnimKitSegmentEntry
    {
        public ushort ParentAnimKitId { get; set; }
        public byte OrderIndex { get; set; }
        public ushort AnimId { get; set; }
        public int AnimStartTime { get; set; }
        public ushort AnimKitConfigId { get; set; }
        public byte StartCondition { get; set; }
        public byte StartConditionParam { get; set; }
        public int StartConditionDelay { get; set; }
        public byte EndCondition { get; set; }
        public int EndConditionParam { get; set; }
        public int EndConditionDelay { get; set; }
        public float Speed { get; set; }
        public ushort SegmentFlags { get; set; }
        public byte ForcedVariation { get; set; }
        public int OverrideConfigFlags { get; set; }
        public byte LoopToSegmentIndex { get; set; }
        public ushort BlendInTimeMs { get; set; }
        public ushort BlendOutTimeMs { get; set; }
    }
}