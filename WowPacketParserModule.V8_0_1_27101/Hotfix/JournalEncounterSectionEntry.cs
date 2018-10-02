using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.JournalEncounterSection, HasIndexInData = false)]
    public class JournalEncounterSectionEntry
    {
        public string Title { get; set; }
        public string BodyText { get; set; }
        public ushort JournalEncounterId { get; set; }
        public byte OrderIndex { get; set; }
        public ushort ParentSectionId { get; set; }
        public ushort FirstChildSectionId { get; set; }
        public ushort NextSiblingSectionId { get; set; }
        public byte Type { get; set; }
        public int IconCreatureDisplayInfoId { get; set; }
        public int UiModelSceneId { get; set; }
        public int SpellId { get; set; }
        public int IconFileDataId { get; set; }
        public ushort Flags { get; set; }
        public ushort IconFlags { get; set; }
        public byte DifficultyMask { get; set; }
    }
}