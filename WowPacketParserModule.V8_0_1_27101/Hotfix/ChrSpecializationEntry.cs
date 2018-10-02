using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ChrSpecialization)]
    public class ChrSpecializationEntry
    {
        public string Name { get; set; }
        public string FemaleName { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public byte ClassId { get; set; }
        public byte OrderIndex { get; set; }
        public byte PetTalentType { get; set; }
        public byte Role { get; set; }
        public uint Flags { get; set; }
        public int SpellIconFileId { get; set; }
        public byte PrimaryStatPriority { get; set; }
        public int AnimReplacements { get; set; }
        [HotfixArray(2)]
        public int[] MasterySpellId { get; set; }
    }
}