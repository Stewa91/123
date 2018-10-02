using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiTextureAtlasMember)]
    public class UiTextureAtlasMemberEntry
    {
        public string CommittedName { get; set; }
        public int ID { get; set; }
        public ushort UiTextureAtlasId { get; set; }
        public ushort CommittedLeft { get; set; }
        public ushort CommittedRight { get; set; }
        public ushort CommittedTop { get; set; }
        public ushort CommittedBottom { get; set; }
        public ushort UiTextureAtlasElementId { get; set; }
        public byte CommittedFlags { get; set; }
        public byte UiCanvasId { get; set; }
    }
}