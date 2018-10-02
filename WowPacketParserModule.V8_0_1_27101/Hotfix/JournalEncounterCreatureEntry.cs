using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.JournalEncounterCreature)]
    public class JournalEncounterCreatureEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public ushort JournalEncounterId { get; set; }
        public int CreatureDisplayInfoId { get; set; }
        public int FileDataId { get; set; }
        public byte OrderIndex { get; set; }
        public uint UiModelSceneId { get; set; }
    }
}