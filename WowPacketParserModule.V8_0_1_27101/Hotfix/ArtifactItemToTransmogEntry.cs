using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ArtifactItemToTransmog, HasIndexInData = false)]
    public class ArtifactItemToTransmogEntry
    {
        public int ItemId { get; set; }
        public int ArtifactId { get; set; }
        public int ChildItemID { get; set; }
    }
}