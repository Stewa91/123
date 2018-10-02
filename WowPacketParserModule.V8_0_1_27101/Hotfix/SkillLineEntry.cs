using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SkillLine)]
    public class SkillLineEntry
    {
        public string DisplayName { get; set; }
        public string AlternateVerb { get; set; }
        public string Description { get; set; }
        public string HordeDisplayName { get; set; }
        public string ExpansionDisplayName { get; set; }
        public int ID { get; set; }
        public byte CategoryId { get; set; }
        public int SpellIconFileId { get; set; }
        public byte CanLink { get; set; }
        public int ParentSkillLineId { get; set; }
        public int ParentTierIndex { get; set; }
        public ushort Flags { get; set; }
    }
}
    