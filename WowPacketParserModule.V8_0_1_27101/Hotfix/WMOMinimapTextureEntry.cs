using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.WmoMinimapTexture, HasIndexInData = false)]
    public class WMOMinimapTextureEntry
    {
        public int FileDataId { get; set; }
        public ushort GroupNum { get; set; }
        public byte BlockX { get; set; }
        public byte BlockY { get; set; }
        public short WMOId { get; set; }
    }
}