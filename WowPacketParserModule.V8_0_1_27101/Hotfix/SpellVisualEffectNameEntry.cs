using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellVisualEffectName, HasIndexInData = false)]
    public class SpellVisualEffectNameEntry
    {
        public int ModelFileDataId { get; set; }
        public float BaseMissileSpeed { get; set; }
        public float Scale { get; set; }
        public float MinAllowedScale { get; set; }
        public float MaxAllowedScale { get; set; }
        public float Alpha { get; set; }
        public int Flags { get; set; }
        public int TextureFileDataId { get; set; }
        public float EffectRadius { get; set; }
        public uint Type { get; set; }
        public int GenericId { get; set; }
        public uint RibbonQualityId { get; set; }
        public int DissolveEffectId { get; set; }
        public int ModelPosition { get; set; }
    }
}