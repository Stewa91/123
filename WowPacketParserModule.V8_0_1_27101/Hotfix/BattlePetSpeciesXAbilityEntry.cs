using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BattlePetSpeciesXAbility, HasIndexInData = false)]
    public class BattlePetSpeciesXAbilityEntry
    {
        public ushort BattlePetAbilityId { get; set; }
        public byte RequiredLevel { get; set; }
        public byte SlotEnum { get; set; }
        public ushort BattlePetSpeciesId { get; set; }
    }
}