using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BattlePetAbilityState, HasIndexInData = false)]
    public class BattlePetAbilityStateEntry
    {
        public byte BattlePetStateId { get; set; }
        public uint Value { get; set; }
        public ushort BattlePetAbilityId { get; set; }
    }
}