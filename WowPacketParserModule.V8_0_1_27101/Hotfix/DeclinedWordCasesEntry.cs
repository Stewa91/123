using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.DeclinedWordCases, HasIndexInData = false)]
    public class DeclinedWordCasesEntry
    {
        public string DeclinedWord { get; set; }
        public byte CaseIndex { get; set; }
        public int DeclinedWordId { get; set; }
    }
}