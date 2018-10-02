using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.RandPropPoints, HasIndexInData = false)]
    public class RandPropPointsEntry
    {
        public int DamageReplaceStat { get; set; }
        [HotfixArray(5)]
        public int[] Epic { get; set; }
        [HotfixArray(5)]
        public int[] Superior { get; set; }
        [HotfixArray(5)]
        public int[] Good { get; set; }
    }
}