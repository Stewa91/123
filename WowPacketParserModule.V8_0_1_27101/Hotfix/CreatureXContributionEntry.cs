using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CreatureXContribution)]
    public class CreatureXContributionEntry
    {
        public int ID { get; set; }
        public int ContributionId { get; set; }
        public int CreatureId { get; set; }
    }
}