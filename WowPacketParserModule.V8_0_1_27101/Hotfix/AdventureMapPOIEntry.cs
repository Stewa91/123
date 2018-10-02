using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AdventureMapPOI, HasIndexInData = false)]
    public class AdventureMapPOIEntry
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [HotfixArray(2)]
        public float[] WorldPosition { get; set; }
        public byte Type { get; set; }
        public uint PlayerConditionId { get; set; }
        public int QuestId { get; set; }
        public uint LfgDungeonId { get; set; }
        public int RewardItemId { get; set; }
        public uint UiTextureAtlasMemberId { get; set; }
        public uint UiTextureKitId { get; set; }
        public int MapId { get; set; }
        public uint AreaTableId { get; set; }
    }
}
    