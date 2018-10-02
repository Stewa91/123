using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrSiteLevel, HasIndexInData = false)]
    public class GarrSiteLevelEntry
    {
        [HotfixArray(2)]
        public float[] TownHallUiPos { get; set; }
        public uint GarrSiteId { get; set; }
        public byte GarrLevel { get; set; }
        public ushort MapId { get; set; }
        public ushort UpgradeMovieId { get; set; }
        public ushort UiTextureKitId { get; set; }
        public byte MaxBuildingLevel { get; set; }
        public ushort UpgradeCost { get; set; }
        public ushort UpgradeGoldCost { get; set; }
    }
}
    