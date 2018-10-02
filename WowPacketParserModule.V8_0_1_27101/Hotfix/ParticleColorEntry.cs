using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ParticleColor, HasIndexInData = false)]
    public class ParticleColorEntry
    {
        [HotfixArray(3)]
        public uint[] Start { get; set; }
        [HotfixArray(3)]
        public uint[] Mid { get; set; }
        [HotfixArray(3)]
        public int[] End { get; set; }
    }
}