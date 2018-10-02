using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ManagedWorldState)]
    public class ManagedWorldStateEntry
    {
        public int ID { get; set; }
        public int CurrentStageWorldStateId { get; set; }
        public int ProgressWorldStateId { get; set; }
        public int UpTimeSecs { get; set; }
        public int DownTimeSecs { get; set; }
        public int OccurrencesWorldStateId { get; set; }
        public int AccumulationStateTargetValue { get; set; }
        public int DepletionStateTargetValue { get; set; }
        public int AccumulationAmountPerMinute { get; set; }
        public int DepletionAmountPerMinute { get; set; }
    }
}