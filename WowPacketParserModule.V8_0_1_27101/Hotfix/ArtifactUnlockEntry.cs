using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ArtifactUnlock, HasIndexInData = false)]
    public class ArtifactUnlockEntry
    {
        public int PowerId { get; set; }
        public byte PowerRank { get; set; }
        public ushort ItemBonusListId { get; set; }
        public uint PlayerConditionId { get; set; }
        public byte ArtifactId { get; set; }
    }
}