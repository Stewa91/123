using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiTextureAtlas, HasIndexInData = false)]
    public class UiTextureAtlasEntry
    {
        public int FileDataId { get; set; }
        public ushort AtlasWidth { get; set; }
        public ushort AtlasHeight { get; set; }
        public byte UiCanvasId { get; set; }
    }
}