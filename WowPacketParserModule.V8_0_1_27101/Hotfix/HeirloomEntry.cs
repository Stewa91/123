using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Heirloom)]
    public class HeirloomEntry
    {
        public string SourceText { get; set; }
        public int ID { get; set; }
        public int ItemId { get; set; }
        public int LegacyUpgradedItemId { get; set; }
        public int StaticUpgradedItemId { get; set; }
        public byte SourceTypeEnum { get; set; }
        public byte Flags { get; set; }
        public int LegacyItemId { get; set; }
        [HotfixArray(3)]
        public int[] UpgradeItemId { get; set; }
        [HotfixArray(3)]
        public ushort[] UpgradeItemBonusListId { get; set; }
    }
}