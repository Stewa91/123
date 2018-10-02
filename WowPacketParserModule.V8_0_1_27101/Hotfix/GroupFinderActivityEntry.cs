using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GroupFinderActivity, HasIndexInData = false)]
    public class GroupFinderActivityEntry
    {
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public byte GroupFinderCategoryId { get; set; }
        public byte OrderIndex { get; set; }
        public byte GroupFinderActivityGrpId { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevelSuggestion { get; set; }
        public int Flags { get; set; }
        public ushort MinGearLevelSuggestion { get; set; }
        public ushort MapId { get; set; }
        public byte DifficultyId { get; set; }
        public ushort AreaId { get; set; }
        public byte MaxPlayers { get; set; }
        public byte DisplayType { get; set; }
    }
}
    