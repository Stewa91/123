using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.JournalEncounterXDifficulty, HasIndexInData = false)]
    public class JournalEncounterXDifficultyEntry
    {
        public byte DifficultyId { get; set; }
        public ushort JournalEncounterId { get; set; }
    }
}