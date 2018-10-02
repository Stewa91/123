using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CreatureDifficulty, HasIndexInData = false)]
    public class CreatureDifficultyEntry
    {
        public byte ExpansionId { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public ushort FactionId { get; set; }
        public int ContentTuningId { get; set; }
        [HotfixArray(7)]
        public uint[] Flags { get; set; }
        public int CreatureId { get; set; }
    }
}