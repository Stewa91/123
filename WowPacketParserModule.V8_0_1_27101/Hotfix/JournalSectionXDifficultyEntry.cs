using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.JournalSectionXDifficulty, HasIndexInData = false)]
    public class JournalSectionXDifficultyEntry
    {
        public byte DifficultyId { get; set; }
        public ushort JournalEncounterSectionId { get; set; }
    }
}