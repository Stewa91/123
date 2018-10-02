using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiMapArtTile, HasIndexInData = false)]
    public class UiMapArtTileEntry
    {
        public byte RowIndex { get; set; }
        public byte ColIndex { get; set; }
        public byte LayerIndex { get; set; }
        public int FileDataId { get; set; }
        public int UiMapArtId { get; set; }
    }
}