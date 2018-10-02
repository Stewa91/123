using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrAbility)]
    public class GarrAbilityEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public byte GarrAbilityCategoryId { get; set; }
        public byte GarrFollowerTypeId { get; set; }
        public int IconFileDataId { get; set; }
        public ushort FactionChangeGarrAbilityId { get; set; }
        public ushort Flags { get; set; }
    }
}