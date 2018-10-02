using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrEncounterXMechanic, HasIndexInData = false)]
    public class GarrEncounterXMechanicEntry
    {
        public byte GarrMechanicId { get; set; }
        public byte GarrMechanicSetId { get; set; }
        public ushort GarrEncounterId { get; set; }
    }
}