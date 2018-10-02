using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.TransmogSetItem)]
    public class TransmogSetItemEntry
    {
        public int ID { get; set; }
        public uint TransmogSetId { get; set; }
        public uint ItemModifiedAppearanceId { get; set; }
        public int Flags { get; set; }
    }
}