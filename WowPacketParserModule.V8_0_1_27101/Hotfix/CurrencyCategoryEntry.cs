using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CurrencyCategory, HasIndexInData = false)]
    public class CurrencyCategoryEntry
    {
        public string Name { get; set; }
        public byte Flags { get; set; }
        public byte ExpansionId { get; set; }
    }
}