using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.WorldEffect, HasIndexInData = false)]
    public class WorldEffectEntry
    {
        public int QuestFeedbackEffectId { get; set; }
        public byte WhenToDisplay { get; set; }
        public byte TargetType { get; set; }
        public uint TargetAsset { get; set; }
        public uint PlayerConditionId { get; set; }
        public ushort CombatConditionId { get; set; }
    }
}