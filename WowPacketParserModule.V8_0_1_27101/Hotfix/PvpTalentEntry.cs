using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.PvpTalent)]
    public class PvpTalentEntry
    {
        public string Description { get; set; }
        public int ID { get; set; }
        public int SpecId { get; set; }
        public int SpellId { get; set; }
        public int OverridesSpellId { get; set; }
        public int Flags { get; set; }
        public int ActionBarSpellId { get; set; }
        public int PvpTalentCategoryId { get; set; }
        public int LevelRequired { get; set; }
    }
}