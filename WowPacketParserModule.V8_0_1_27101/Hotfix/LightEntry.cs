using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Light, HasIndexInData = false)]
    public class LightEntry
    {
        [HotfixArray(3)]
        public float[] GameCoords { get; set; }
        public float GameFalloffStart { get; set; }
        public float GameFalloffEnd { get; set; }
        public ushort ContinentId { get; set; }
        [HotfixArray(8)]
        public ushort[] LightParamsId { get; set; }
    }
}