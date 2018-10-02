using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ChrUpgradeBucket)]
    public class ChrUpgradeBucketEntry
    {
        public int ID { get; set; }
        public ushort ChrSpecializationId { get; set; }
        public byte ChrUpgradeTierId { get; set; }
    }
}