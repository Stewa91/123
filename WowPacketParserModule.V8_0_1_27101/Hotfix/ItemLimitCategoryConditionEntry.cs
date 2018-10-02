using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemLimitCategoryCondition, HasIndexInData = false)]
    public class ItemLimitCategoryConditionEntry
    {
        public byte AddQuantity { get; set; }
        public uint PlayerConditionId { get; set; }
        public int ParentItemLimitCategoryId { get; set; }
    }
}