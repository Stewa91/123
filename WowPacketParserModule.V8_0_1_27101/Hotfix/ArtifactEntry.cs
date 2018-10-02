using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Artifact)]
    public class ArtifactEntry
    {
        public string Name { get; set; }
        public uint ID { get; set; }
        public ushort UiTextureKitId { get; set; }
        public uint UiNameColor { get; set; }
        public uint UiBarOverlayColor { get; set; }
        public uint UiBarBackgroundColor { get; set; }
        public ushort ChrSpecializationId { get; set; }
        public byte Flags { get; set; }
        public byte ArtifactCategoryId { get; set; }
        public uint UiModelSceneId { get; set; }
        public int SpellVisualKitId { get; set; }
    }
}