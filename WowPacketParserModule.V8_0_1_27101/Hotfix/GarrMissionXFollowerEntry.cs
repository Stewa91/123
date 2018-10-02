using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrMissionXFollower, HasIndexInData = false)]
    public class GarrMissionXFollowerEntry
    {
        public int GarrFollowerId { get; set; }
        public int GarrFollowerSetId { get; set; }
        public int GarrMissionId { get; set; }
    }
}