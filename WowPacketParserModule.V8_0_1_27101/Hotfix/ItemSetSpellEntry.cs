using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemSetSpell, HasIndexInData = false)]
    public class ItemSetSpellEntry
    {
        public ushort ChrSpecId { get; set; }
        public int SpellId { get; set; }
        public byte Threshold { get; set; }
        public ushort ItemSetId { get; set; }
    }
}