using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemModifiedAppearance)]
    public class ItemModifiedAppearanceEntry
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public byte ItemAppearanceModifierId { get; set; }
        public ushort ItemAppearanceId { get; set; }
        public byte OrderIndex { get; set; }
        public sbyte TransmogSourceTypeEnum { get; set; }
    }
}