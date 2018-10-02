using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Item, HasIndexInData = false)]
    public class ItemEntry
    {
        public byte ClassId { get; set; }
        public byte SubclassId { get; set; }
        public byte Material { get; set; }
        public byte InventoryType { get; set; }
        public byte SheatheType { get; set; }
        public byte SoundOverrideSubclassId { get; set; }
        public int IconFileDataId { get; set; }
        public byte ItemGroupSoundsId { get; set; }
    }
}