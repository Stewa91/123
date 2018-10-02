using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BattlePetAbilityEffect)]
    public class BattlePetAbilityEffectEntry
    {
        public int ID { get; set; }
        public ushort BattlePetAbilityTurnId { get; set; }
        public byte OrderIndex { get; set; }
        public ushort BattlePetEffectPropertiesId { get; set; }
        public ushort AuraBattlePetAbilityId { get; set; }
        public ushort BattlePetVisualId { get; set; }
        [HotfixArray(6)]
        public ushort[] Param { get; set; }
    }
}