using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpecializationSpells)]
    public class SpecializationSpellsEntry
    {
        public string Description { get; set; }
        public int ID { get; set; }
        public ushort SpecId { get; set; }
        public int SpellId { get; set; }
        public int OverridesSpellId { get; set; }
        public byte DisplayOrder { get; set; }
    }
}