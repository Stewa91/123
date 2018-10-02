using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.QuestObjective, HasIndexInData = false)]
    public class QuestObjectiveEntry
    {
        public string Description { get; set; }
        public byte Type { get; set; }
        public int Amount { get; set; }
        public int ObjectId { get; set; }
        public byte OrderIndex { get; set; }
        public byte Flags { get; set; }
        public byte StorageIndex { get; set; }
        public ushort QuestId { get; set; }
    }
}