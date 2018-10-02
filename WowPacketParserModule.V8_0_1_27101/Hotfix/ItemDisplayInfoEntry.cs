using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemDisplayInfo, HasIndexInData = false)]
    public class ItemDisplayInfoEntry
    {
        public int ModelType1 { get; set; }
        public int ItemVisual { get; set; }
        public int ParticleColorId { get; set; }
        public int ItemRangedDisplayInfoId { get; set; }
        public int OverrideSwooshSoundKitId { get; set; }
        public int SheatheTransformMatrixId { get; set; }
        public int StateSpellVisualKitId { get; set; }
        public int SheathedSpellVisualKitId { get; set; }
        public uint UnsheathedSpellVisualKitId { get; set; }
        public int Flags { get; set; }
        [HotfixArray(2)]
        public int[] ModelResourcesId { get; set; }
        [HotfixArray(2)]
        public int[] ModelMaterialResourcesId { get; set; }
        [HotfixArray(6)]
        public int[] GeosetGroup { get; set; }
        [HotfixArray(6)]
        public int[] AttachmentGeosetGroup { get; set; }
        [HotfixArray(2)]
        public int[] HelmetGeosetVis { get; set; }
    }
}