using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemLevelSelectorQuality, HasIndexInData = false)]
    public class ItemLevelSelectorQualityEntry
    {
        public int QualityItemBonusListId { get; set; }
        public byte Quality { get; set; }
        public short ParentILSQualitySetId { get; set; }
    }
}