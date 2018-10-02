using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellCategories, HasIndexInData = false)]
    public class SpellCategoriesEntry
    {
        public byte DifficultyId { get; set; }
        public ushort Category { get; set; }
        public byte DefenseType { get; set; }
        public byte DispelType { get; set; }
        public byte Mechanic { get; set; }
        public byte PreventionType { get; set; }
        public ushort StartRecoveryCategory { get; set; }
        public ushort ChargeCategory { get; set; }
        public int SpellId { get; set; }
    }
}