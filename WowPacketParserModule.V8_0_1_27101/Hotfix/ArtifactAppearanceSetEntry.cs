using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ArtifactAppearanceSet)]
    public class ArtifactAppearanceSetEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public sbyte DisplayIndex { get; set; }
        public ushort UiCameraId { get; set; }
        public ushort AltHandUICameraId { get; set; }
        public sbyte ForgeAttachmentOverride { get; set; }
        public sbyte Flags { get; set; }
        public byte ArtifactId { get; set; }
    }
}