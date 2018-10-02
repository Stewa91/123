using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ZoneMusic, HasIndexInData = false)]
    public class ZoneMusicEntry
    {
        public string SetName { get; set; }
        [HotfixArray(2)]
        public int[] SilenceIntervalMin { get; set; }
        [HotfixArray(2)]
        public int[] SilenceIntervalMax { get; set; }
        [HotfixArray(2)]
        public int[] Sounds { get; set; }
    }
}