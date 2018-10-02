using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.PvpScalingEffect, HasIndexInData = false)]
    public class PvpScalingEffectEntry
    {
        public int SpecializationId { get; set; }
        public int PvpScalingEffectTypeId { get; set; }
        public float Value { get; set; }
    }
}