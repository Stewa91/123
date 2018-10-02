using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellReagentsCurrency, HasIndexInData = false)]
    public class SpellReagentsCurrencyEntry
    {
        public int SpellId { get; set; }
        public ushort CurrencyTypesId { get; set; }
        public ushort CurrencyCount { get; set; }
    }
}