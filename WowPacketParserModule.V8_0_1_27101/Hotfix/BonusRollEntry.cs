using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BonusRoll, HasIndexInData = false)]
    public class BonusRollEntry
    {
        public int CurrencyTypesId { get; set; }
        public uint CurrencyCost { get; set; }
        public uint JournalEncounterId { get; set; }
        public uint JournalInstanceId { get; set; }
    }
}