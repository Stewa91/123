using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Cfg_Regions, HasIndexInData = false)]
    public class Cfg_RegionsEntry
    {
        public string Tag { get; set; }
        public ushort RegionId { get; set; }
        public int Raidorigin { get; set; }
        public byte RegionGroupMask { get; set; }
        public int ChallengeOrigin { get; set; }
    }
}