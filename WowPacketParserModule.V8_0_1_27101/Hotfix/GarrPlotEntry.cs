using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrPlot, HasIndexInData = false)]
    public class GarrPlotEntry
    {
        public string Name { get; set; }
        public byte PlotType { get; set; }
        public int HordeConstructObjId { get; set; }
        public int AllianceConstructObjId { get; set; }
        public byte Flags { get; set; }
        public byte UiCategoryId { get; set; }
        [HotfixArray(2)]
        public int[] UpgradeRequirement { get; set; }
    }
}