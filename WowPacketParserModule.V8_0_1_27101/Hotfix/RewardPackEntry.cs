using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.RewardPack, HasIndexInData = false)]
    public class RewardPackEntry
    {
        public int CharTitleId { get; set; }
        public int Money { get; set; }
        public byte ArtifactXPDifficulty { get; set; }
        public float ArtifactXPMultiplier { get; set; }
        public byte ArtifactXPCategoryId { get; set; }
        public uint TreasurePickerId { get; set; }
    }
}