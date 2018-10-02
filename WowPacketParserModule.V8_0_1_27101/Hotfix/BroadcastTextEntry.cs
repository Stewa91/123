using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BroadcastText)]
    public class BroadcastTextEntry
    {
        public string Text { get; set; }
        public string Text1 { get; set; }
        public int ID { get; set; }
        public byte LanguageId { get; set; }
        public int ConditionId { get; set; }
        public ushort EmotesId { get; set; }
        public byte Flags { get; set; }
        public int ChatBubbleDurationMs { get; set; }
        [HotfixArray(2)]
        public int[] SoundEntriesId { get; set; }
        [HotfixArray(3)]
        public ushort[] EmoteId { get; set; }
        [HotfixArray(3)]
        public ushort[] EmoteDelay { get; set; }
    }
}