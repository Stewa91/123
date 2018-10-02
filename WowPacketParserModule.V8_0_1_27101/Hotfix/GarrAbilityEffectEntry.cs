using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrAbilityEffect)]
    public class GarrAbilityEffectEntry
    {
        public int ID { get; set; }
        public ushort GarrAbilityId { get; set; }
        public byte AbilityAction { get; set; }
        public byte AbilityTargetType { get; set; }
        public byte GarrMechanicTypeId { get; set; }
        public float CombatWeightBase { get; set; }
        public float CombatWeightMax { get; set; }
        public float ActionValueFlat { get; set; }
        public byte ActionRace { get; set; }
        public byte ActionHours { get; set; }
        public int ActionRecordId { get; set; }
        public byte Flags { get; set; }
    }
}