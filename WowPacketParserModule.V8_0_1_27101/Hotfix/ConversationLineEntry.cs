using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ConversationLine, HasIndexInData = false)]
    public class ConversationLineEntry
    {
        public int BroadcastTextId { get; set; }
        public int SpellVisualKitId { get; set; }
        public uint AdditionalDuration { get; set; }
        public ushort NextConversationLineId { get; set; }
        public ushort AnimKitId { get; set; }
        public byte SpeechType { get; set; }
        public byte StartAnimation { get; set; }
        public byte EndAnimation { get; set; }
    }
}