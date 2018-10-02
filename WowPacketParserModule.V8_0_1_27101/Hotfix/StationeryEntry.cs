using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Stationery, HasIndexInData = false)]
    public class StationeryEntry
    {
        public uint ItemId { get; set; }
        public byte Flags { get; set; }
        [HotfixArray(2)]
        public int[] TextureFileDataId { get; set; }
    }
}