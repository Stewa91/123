using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SkillLineAbility)]
    public class SkillLineAbilityEntry
    {
        public ulong RaceMask { get; set; }
        public int ID { get; set; }
        public ushort SkillLine { get; set; }
        public int Spell { get; set; }
        public ushort MinSkillLineRank { get; set; }
        public int ClassMask { get; set; }
        public int SupercedesSpell { get; set; }
        public byte AcquireMethod { get; set; }
        public ushort TrivialSkillLineRankHigh { get; set; }
        public ushort TrivialSkillLineRankLow { get; set; }
        public byte Flags { get; set; }
        public byte NumSkillUps { get; set; }
        public ushort UniqueBit { get; set; }
        public ushort TradeSkillCategoryId { get; set; }
        public ushort SkillupSkillLineId { get; set; }
    }
}