using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.MovieVariation, HasIndexInData = false)]
    public class MovieVariationEntry
    {
        public int FileDataId { get; set; }
        public uint OverlayFileDataId { get; set; }
        public int MovieId { get; set; }
    }
}