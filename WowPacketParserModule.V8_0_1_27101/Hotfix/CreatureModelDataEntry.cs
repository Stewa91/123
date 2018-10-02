using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CreatureModelData, HasIndexInData = false)]
    public class CreatureModelDataEntry
    {
        [HotfixArray(6)]
        public float[] GeoBox { get; set; }
        public int Flags { get; set; }
        public int FileDataId { get; set; }
        public int BloodId { get; set; }
        public int FootprintTextureId { get; set; }
        public float FootprintTextureLength { get; set; }
        public float FootprintTextureWidth { get; set; }
        public float FootprintParticleScale { get; set; }
        public uint FoleyMaterialId { get; set; }
        public uint FootstepCameraEffectId { get; set; }
        public int DeathThudCameraEffectId { get; set; }
        public int SoundId { get; set; }
        public int SizeClass { get; set; }
        public float CollisionWidth { get; set; }
        public float CollisionHeight { get; set; }
        public float WorldEffectScale { get; set; }
        public int CreatureGeosetDataId { get; set; }
        public float HoverHeight { get; set; }
        public float AttachedEffectScale { get; set; }
        public float ModelScale { get; set; }
        public float MissileCollisionRadius { get; set; }
        public float MissileCollisionPush { get; set; }
        public float MissileCollisionRaise { get; set; }
        public float MountHeight { get; set; }
        public float OverrideLootEffectScale { get; set; }
        public float OverrideNameScale { get; set; }
        public float OverrideSelectionRadius { get; set; }
        public float TamedPetBaseScale { get; set; }
    }
}