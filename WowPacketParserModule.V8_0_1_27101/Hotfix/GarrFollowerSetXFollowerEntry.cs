using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrFollowerSetXFollower, HasIndexInData = false)]
    public class GarrFollowerSetXFollowerEntry
    {
        public int GarrFollowerId { get; set; }
        public int GarrFollowerSetId { get; set; }
    }
}