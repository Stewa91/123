using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.TransportAnimation, HasIndexInData = false)]
    public class TransportAnimationEntry
    {
        [HotfixArray(3)]
        public float[] Pos { get; set; }
        public byte SequenceId { get; set; }
        public int TimeIndex { get; set; }
        public int TransportId { get; set; }
    }
}