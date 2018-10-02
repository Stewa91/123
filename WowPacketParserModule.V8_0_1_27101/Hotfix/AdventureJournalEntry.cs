using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AdventureJournal, HasIndexInData = false)]
    public class AdventureJournalEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ButtonText { get; set; }
        public string RewardDescription { get; set; }
        public string ContinueDescription { get; set; }
        public byte Type { get; set; }
        public int PlayerConditionId { get; set; }
        public byte Flags { get; set; }
        public byte ButtonActionType { get; set; }
        public int TextureFileDataId { get; set; }
        public ushort LfgDungeonId { get; set; }
        public ushort QuestId { get; set; }
        public ushort BattleMasterListId { get; set; }
        public byte PriorityMin { get; set; }
        public byte PriorityMax { get; set; }
        public int ItemId { get; set; }
        public int ItemQuantity { get; set; }
        public ushort CurrencyType { get; set; }
        public byte CurrencyQuantity { get; set; }
        public ushort WorldMapAreaId { get; set; }
        [HotfixArray(2)]
        public int[] BonusPlayerConditionId { get; set; }
        [HotfixArray(2)]
        public byte[] BonusValue { get; set; }
    }
}