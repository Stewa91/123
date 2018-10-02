using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.RewardPackXItem, HasIndexInData = false)]
    public class RewardPackXItemEntry
    {
        public int ItemId { get; set; }
        public int ItemQuantity { get; set; }
        public int RewardPackId { get; set; }
    }
}