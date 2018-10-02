using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrMechanic, HasIndexInData = false)]
    public class GarrMechanicEntry
    {
        public byte GarrMechanicTypeId { get; set; }
        public float Factor { get; set; }
        public int GarrAbilityId { get; set; }
    }
}