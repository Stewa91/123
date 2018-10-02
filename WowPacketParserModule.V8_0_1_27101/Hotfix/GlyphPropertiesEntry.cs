using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GlyphProperties, HasIndexInData = false)]
    public class GlyphPropertiesEntry
    {
        public int SpellId { get; set; }
        public ushort SpellIconId { get; set; }
        public byte GlyphType { get; set; }
        public byte GlyphExclusiveCategoryId { get; set; }
    }
}