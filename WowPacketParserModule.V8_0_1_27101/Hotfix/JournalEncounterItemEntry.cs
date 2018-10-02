using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.JournalEncounterItem)]
    public class JournalEncounterItemEntry
    {
        public uint ID { get; set; }
        public ushort JournalEncounterId { get; set; }
        public int ItemId { get; set; }
        public byte FactionMask { get; set; }
        public byte Flags { get; set; }
        public byte DifficultyMask { get; set; }
    }
}