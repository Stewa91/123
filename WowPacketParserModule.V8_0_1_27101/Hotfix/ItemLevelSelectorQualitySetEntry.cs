using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemLevelSelectorQualitySet, HasIndexInData = false)]
    public class ItemLevelSelectorQualitySetEntry
    {
        public ushort IlvlRare { get; set; }
        public ushort IlvlEpic { get; set; }
    }
}