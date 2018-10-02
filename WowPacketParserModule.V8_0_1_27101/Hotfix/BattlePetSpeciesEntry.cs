using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BattlePetSpecies)]
    public class BattlePetSpeciesEntry
    {
        public string Description { get; set; }
        public string SourceText { get; set; }
        public int ID { get; set; }
        public int CreatureId { get; set; }
        public int SummonSpellId { get; set; }
        public int IconFileDataId { get; set; }
        public byte PetTypeEnum { get; set; }
        public ushort Flags { get; set; }
        public byte SourceTypeEnum { get; set; }
        public int CardUIModelSceneId { get; set; }
        public int LoadoutUIModelSceneId { get; set; }
    }
}