using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrClassSpecPlayerCond, HasIndexInData = false)]
    public class GarrClassSpecPlayerCondEntry
    {
        public string Name { get; set; }
        public uint GarrClassSpecId { get; set; }
        public int PlayerConditionId { get; set; }
        public int IconFileDataId { get; set; }
        public int FlavorGarrStringId { get; set; }
        public byte OrderIndex { get; set; }
    }
}