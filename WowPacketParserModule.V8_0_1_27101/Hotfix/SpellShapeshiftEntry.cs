using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellShapeshift, HasIndexInData = false)]
    public class SpellShapeshiftEntry
    {
        public int SpellId { get; set; }
        public byte StanceBarOrder { get; set; }
        [HotfixArray(2)]
        public uint[] ShapeshiftExclude { get; set; }
        [HotfixArray(2)]
        public uint[] ShapeshiftMask { get; set; }
    }
}