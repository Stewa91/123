using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellCastingRequirements, HasIndexInData = false)]
    public class SpellCastingRequirementsEntry
    {
        public int SpellId { get; set; }
        public byte FacingCasterFlags { get; set; }
        public ushort MinFactionId { get; set; }
        public byte MinReputation { get; set; }
        public ushort RequiredAreasId { get; set; }
        public byte RequiredAuraVision { get; set; }
        public ushort RequiresSpellFocus { get; set; }
    }
}