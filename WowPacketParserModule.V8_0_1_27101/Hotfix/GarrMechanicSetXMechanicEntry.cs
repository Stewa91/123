using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrMechanicSetXMechanic)]
    public class GarrMechanicSetXMechanicEntry
    {
        public int ID { get; set; }
        public byte GarrMechanicId { get; set; }
        public uint GarrMechanicSetId { get; set; }
    }
}