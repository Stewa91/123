using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.WeaponImpactSounds, HasIndexInData = false)]
    public class WeaponImpactSoundsEntry
    {
        public byte WeaponSubClassId { get; set; }
        public byte ParrySoundType { get; set; }
        public byte ImpactSource { get; set; }
        [HotfixArray(11)]
        public int[] ImpactSoundId { get; set; }
        [HotfixArray(11)]
        public int[] CritImpactSoundId { get; set; }
        [HotfixArray(11)]
        public int[] PierceImpactSoundId { get; set; }
        [HotfixArray(11)]
        public int[] PierceCritImpactSoundId { get; set; }
    }
}