using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.PrestigeLevelInfo, HasIndexInData = false)]
    public class PrestigeLevelInfoEntry
    {
        public string Name { get; set; }
        public int HonorLevel { get; set; }
        public int BadgeTextureFileDataId { get; set; }
        public byte Flags { get; set; }
        public int AwardedAchievementID { get; set; }
    }
}