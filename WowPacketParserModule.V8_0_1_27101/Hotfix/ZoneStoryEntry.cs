using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ZoneStory, HasIndexInData = false)]
    public class ZoneStoryEntry
    {
        public byte PlayerFactionGroupId { get; set; }
        public uint DisplayAchievementId { get; set; }
        public int DisplayWorldMapAreaId { get; set; }
        public int PlayerWorldMapAreaId { get; set; }
    }
}