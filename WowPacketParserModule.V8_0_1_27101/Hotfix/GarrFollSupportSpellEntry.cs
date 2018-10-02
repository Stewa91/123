using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrFollSupportSpell, HasIndexInData = false)]
    public class GarrFollSupportSpellEntry
    {
        public int HordeSpellId { get; set; }
        public int AllianceSpellId { get; set; }
        public byte OrderIndex { get; set; }
        public int GarrFollowerId { get; set; }
    }
}