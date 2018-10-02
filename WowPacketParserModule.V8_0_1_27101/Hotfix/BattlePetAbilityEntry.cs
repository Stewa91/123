using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BattlePetAbility, HasIndexInData = false)]
    public class BattlePetAbilityEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int IconFileDataId { get; set; }
        public byte PetTypeEnum { get; set; }
        public int Cooldown { get; set; }
        public ushort BattlePetVisualId { get; set; }
        public byte Flags { get; set; }
    }
}