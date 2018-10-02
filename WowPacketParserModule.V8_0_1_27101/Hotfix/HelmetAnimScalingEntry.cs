using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.HelmetAnimScaling, HasIndexInData = false)]
    public class HelmetAnimScalingEntry
    {
        public int RaceId { get; set; }
        public float Amount { get; set; }
        public int HelmetGeosetVisDataId { get; set; }
    }
}