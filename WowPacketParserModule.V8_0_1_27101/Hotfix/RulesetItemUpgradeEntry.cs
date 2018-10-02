using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.RulesetItemUpgrade, HasIndexInData = false)]
    public class RulesetItemUpgradeEntry
    {
        public int ItemId { get; set; }
        public ushort ItemUpgradeId { get; set; }
    }
}