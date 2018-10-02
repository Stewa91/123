using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CreatureDisplayInfo)]
    public class CreatureDisplayInfoEntry
    {
        public int ID { get; set; }
        public ushort ModelId { get; set; }
        public ushort SoundId { get; set; }
        public byte SizeClass { get; set; }
        public float CreatureModelScale { get; set; }
        public byte CreatureModelAlpha { get; set; }
        public byte BloodId { get; set; }
        public int ExtendedDisplayInfoId { get; set; }
        public ushort NPCSoundId { get; set; }
        public ushort ParticleColorId { get; set; }
        public int PortraitCreatureDisplayInfoId { get; set; }
        public int PortraitTextureFileDataId { get; set; }
        public ushort ObjectEffectPackageId { get; set; }
        public ushort AnimReplacementSetId { get; set; }
        public byte Flags { get; set; }
        public int StateSpellVisualKitId { get; set; }
        public float PlayerOverrideScale { get; set; }
        public float PetInstanceScale { get; set; }
        public byte UnarmedWeaponType { get; set; }
        public int MountPoofSpellVisualKitId { get; set; }
        public int DissolveEffectId { get; set; }
        public byte Gender { get; set; }
        public int DissolveOutEffectId { get; set; }
        public byte CreatureModelMinLod { get; set; }
        [HotfixArray(3)]
        public int[] TextureVariationFileDataId { get; set; }
    }
}