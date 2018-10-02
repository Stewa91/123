using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.QuestFeedbackEffect, HasIndexInData = false)]
    public class QuestFeedbackEffectEntry
    {
        public int FileDataId { get; set; }
        public ushort MinimapAtlasMemberId { get; set; }
        public byte AttachPoint { get; set; }
        public byte PassiveHighlightColorType { get; set; }
        public byte Priority { get; set; }
        public byte Flags { get; set; }
    }
}