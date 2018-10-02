using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GlyphRequiredSpec, HasIndexInData = false)]
    public class GlyphRequiredSpecEntry
    {
        public ushort ChrSpecializationId { get; set; }
        public ushort GlyphPropertiesId { get; set; }
    }
}