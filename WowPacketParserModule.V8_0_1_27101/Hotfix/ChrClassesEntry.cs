using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ChrClasses)]
    public class ChrClassesEntry
    {
        public string Name { get; set; }
        public string Filename { get; set; }
        public string NameMale { get; set; }
        public string NameFemale { get; set; }
        public string PetNameToken { get; set; }
        public int ID { get; set; }
        public int CreateScreenFileDataId { get; set; }
        public int SelectScreenFileDataId { get; set; }
        public int IconFileDataId { get; set; }
        public int LowResScreenFileDataId { get; set; }
        public int StartingLevel { get; set; }
        public ushort Flags { get; set; }
        public ushort CinematicSequenceId { get; set; }
        public ushort DefaultSpec { get; set; }
        public byte PrimaryStatPriority { get; set; }
        public byte DisplayPower { get; set; }
        public byte RangedAttackPowerPerAgility { get; set; }
        public byte AttackPowerPerAgility { get; set; }
        public byte AttackPowerPerStrength { get; set; }
        public byte SpellClassSet { get; set; }
    }
}
    