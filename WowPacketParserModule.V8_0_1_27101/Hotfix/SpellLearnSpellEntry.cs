using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellLearnSpell, HasIndexInData = false)]
    public class SpellLearnSpellEntry
    {
        public int SpellId { get; set; }
        public int LearnSpellId { get; set; }
        public int OverridesSpellId { get; set; }
    }
}