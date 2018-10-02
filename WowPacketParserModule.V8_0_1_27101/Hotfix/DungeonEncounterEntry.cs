using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.DungeonEncounter)]
    public class DungeonEncounterEntry
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public ushort MapId { get; set; }
        public byte DifficultyId { get; set; }
        public int OrderIndex { get; set; }
        public byte Bit { get; set; }
        public int CreatureDisplayID { get; set; }
        public byte Flags { get; set; }
        public int SpellIconFileId { get; set; }
    }
}