using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ArtifactAppearance)]
    public class ArtifactAppearanceEntry
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public ushort ArtifactAppearanceSetId { get; set; }
        public byte DisplayIndex { get; set; }
        public int UnlockPlayerConditionId { get; set; }
        public byte ItemAppearanceModifierId { get; set; }
        public int UiSwatchColor { get; set; }
        public float UiModelSaturation { get; set; }
        public float UiModelOpacity { get; set; }
        public byte OverrideShapeshiftFormId { get; set; }
        public int OverrideShapeshiftDisplayId { get; set; }
        public int UiItemAppearanceId { get; set; }
        public int UiAltItemAppearanceId { get; set; }
        public byte Flags { get; set; }
        public ushort UiCameraId { get; set; }
    }
}
    