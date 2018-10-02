using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellAuraVisXChrSpec, HasIndexInData = false)]
    public class SpellAuraVisXChrSpecEntry
    {
        public ushort ChrSpecializationId { get; set; }
        public short SpellAuraVisibilityId { get; set; }
    }
}