using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrBuildingPlotInst)]
    public class GarrBuildingPlotInstEntry
    {
        [HotfixArray(2)]
        public float[] MapOffset { get; set; }
        public int ID { get; set; }
        public byte GarrBuildingId { get; set; }
        public ushort GarrSiteLevelPlotInstId { get; set; }
        public ushort UiTextureAtlasMemberId { get; set; }
    }
}