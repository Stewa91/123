using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellActivationOverlay, HasIndexInData = false)]
    public class SpellActivationOverlayEntry
    {
        [HotfixArray(4)]
        public uint[] IconHighlightSpellClassMask { get; set; }
        public int SpellId { get; set; }
        public int OverlayFileDataId { get; set; }
        public byte ScreenLocationId { get; set; }
        public uint SoundEntriesId { get; set; }
        public uint Color { get; set; }
        public float Scale { get; set; }
        public byte TriggerType { get; set; }
    }
}