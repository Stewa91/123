using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.JournalEncounter, HasIndexInData = false)]
    public class JournalEncounterEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [HotfixArray(2)]
        public float[] Map { get; set; }
        public ushort JournalInstanceId { get; set; }
        public int OrderIndex { get; set; }
        public ushort FirstSectionId { get; set; }
        public ushort UiMapId { get; set; }
        public int MapDisplayConditionId { get; set; }
        public byte Flags { get; set; }
        public byte DifficultyMask { get; set; }
    }
}