using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Talent, HasIndexInData = false)]
    public class TalentEntry
    {
        public string Description { get; set; }
        public byte TierId { get; set; }
        public byte Flags { get; set; }
        public byte ColumnIndex { get; set; }
        public byte ClassId { get; set; }
        public ushort SpecId { get; set; }
        public int SpellId { get; set; }
        public int OverridesSpellId { get; set; }
        [HotfixArray(2)]
        public byte[] CategoryMask { get; set; }
    }
}