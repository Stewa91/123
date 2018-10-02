using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CampaignXCondition, HasIndexInData = false)]
    public class CampaignXConditionEntry
    {
        public uint PlayerConditionId { get; set; }
        public uint OrderIndex { get; set; }
        public uint CampaignId { get; set; }
    }
}