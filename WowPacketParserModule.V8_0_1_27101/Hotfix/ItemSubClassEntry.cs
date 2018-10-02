using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemSubClass, HasIndexInData = false)]
    public class ItemSubClassEntry
    {
        public string DisplayName { get; set; }
        public string VerboseName { get; set; }
        public byte ClassId { get; set; }
        public byte SubClassId { get; set; }
        public byte AuctionHouseSortOrder { get; set; }
        public byte PrerequisiteProficiency { get; set; }
        public ushort Flags { get; set; }
        public byte DisplayFlags { get; set; }
        public byte WeaponSwingSize { get; set; }
        public byte PostrequisiteProficiency { get; set; }
    }
}