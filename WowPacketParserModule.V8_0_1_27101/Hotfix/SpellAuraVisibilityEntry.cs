using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellAuraVisibility)]
    public class SpellAuraVisibilityEntry
    {
        public int ID { get; set; }
        public byte Type { get; set; }
        public byte Flags { get; set; }
        public int SpellId { get; set; }
    }
}