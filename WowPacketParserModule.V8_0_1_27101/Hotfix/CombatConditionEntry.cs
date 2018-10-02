using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CombatCondition, HasIndexInData = false)]
    public class CombatConditionEntry
    {
        public ushort WorldStateExpressionId { get; set; }
        public ushort SelfConditionId { get; set; }
        public ushort TargetConditionId { get; set; }
        public byte FriendConditionLogic { get; set; }
        public byte EnemyConditionLogic { get; set; }
        [HotfixArray(2)]
        public ushort[] FriendConditionId { get; set; }
        [HotfixArray(2)]
        public byte[] FriendConditionOp { get; set; }
        [HotfixArray(2)]
        public byte[] FriendConditionCount { get; set; }
        [HotfixArray(2)]
        public ushort[] EnemyConditionId { get; set; }
        [HotfixArray(2)]
        public byte[] EnemyConditionOp { get; set; }
        [HotfixArray(2)]
        public byte[] EnemyConditionCount { get; set; }
    }
}