using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.PvpBracketTypes, HasIndexInData = false)]
    public class PVPBracketTypesEntry
    {
        public byte BracketId { get; set; }
        [HotfixArray(4)]
        public int[] WeeklyQuestId { get; set; }
    }
}