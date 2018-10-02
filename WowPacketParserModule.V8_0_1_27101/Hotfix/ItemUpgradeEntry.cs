using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemUpgrade, HasIndexInData = false)]
    public class ItemUpgradeEntry
    {
        public byte ItemUpgradePathId { get; set; }
        public byte ItemLevelIncrement { get; set; }
        public ushort PrerequisiteId { get; set; }
        public ushort CurrencyType { get; set; }
        public int CurrencyAmount { get; set; }
    }
}