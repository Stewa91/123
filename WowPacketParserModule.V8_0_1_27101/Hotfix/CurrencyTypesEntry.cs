using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CurrencyTypes, HasIndexInData = false)]
    public class CurrencyTypesEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte CategoryId { get; set; }
        public int InventoryIconFileId { get; set; }
        public int SpellWeight { get; set; }
        public byte SpellCategory { get; set; }
        public int MaxQty { get; set; }
        public int MaxEarnablePerWeek { get; set; }
        public int Flags { get; set; }
        public byte Quality { get; set; }
    }
}