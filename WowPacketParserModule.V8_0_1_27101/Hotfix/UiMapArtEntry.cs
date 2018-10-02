using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiMapArt, HasIndexInData = false)]
    public class UiMapArtEntry
    {
        public int HighlightFileDataId { get; set; }
        public int UiMapArtStyleId { get; set; }
    }
}