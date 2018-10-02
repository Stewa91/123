using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemModifiedAppearanceExtra, HasIndexInData = false)]
    public class ItemModifiedAppearanceExtraEntry
    {
        public int IconFileDataId { get; set; }
        public int UnequippedIconFileDataId { get; set; }
        public byte SheatheType { get; set; }
        public byte DisplayWeaponSubclassId { get; set; }
        public byte DisplayInventoryType { get; set; }
    }
}