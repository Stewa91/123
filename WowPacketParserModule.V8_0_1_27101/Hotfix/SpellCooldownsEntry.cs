using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellCooldowns, HasIndexInData = false)]
    public class SpellCooldownsEntry
    {
        public byte DifficultyId { get; set; }
        public int CategoryRecoveryTime { get; set; }
        public int RecoveryTime { get; set; }
        public int StartRecoveryTime { get; set; }
        public int SpellId { get; set; }
    }
}