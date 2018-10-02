using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ManagedWorldStateBuff, HasIndexInData = false)]
    public class ManagedWorldStateBuffEntry
    {
        public int BuffSpellId { get; set; }
        public int PlayerConditionId { get; set; }
        public int OccurrenceValue { get; set; }
        public int ManagedWorldStateId { get; set; }
    }
}