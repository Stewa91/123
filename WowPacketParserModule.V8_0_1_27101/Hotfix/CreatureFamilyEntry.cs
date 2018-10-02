using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CreatureFamily, HasIndexInData = false)]
    public class CreatureFamilyEntry
    {
        public string Name { get; set; }
        public float MinScale { get; set; }
        public byte MinScaleLevel { get; set; }
        public float MaxScale { get; set; }
        public byte MaxScaleLevel { get; set; }
        public ushort PetFoodMask { get; set; }
        public byte PetTalentType { get; set; }
        public int IconFileId { get; set; }
        [HotfixArray(2)]
        public ushort[] SkillLine { get; set; }
    }
}