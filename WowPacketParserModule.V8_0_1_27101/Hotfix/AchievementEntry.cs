using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Achievement)]
    public class AchievementEntry
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public string Reward { get; set; }
        public uint ID { get; set; }
        public ushort InstanceId { get; set; }
        public byte Faction { get; set; }
        public ushort Supercedes { get; set; }
        public ushort Category { get; set; }
        public byte MinimumCriteria { get; set; }
        public byte Points { get; set; }
        public int Flags { get; set; }
        public ushort UiOrder { get; set; }
        public int IconFileId { get; set; }
        public int CriteriaTree { get; set; }
        public ushort SharesCriteria { get; set; }
    }
}