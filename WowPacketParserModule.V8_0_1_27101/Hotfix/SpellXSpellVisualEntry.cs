using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellXSpellVisual)]
    public class SpellXSpellVisualEntry
    {
        public int ID { get; set; }
        public byte DifficultyId { get; set; }
        public int SpellVisualId { get; set; }
        public float Probability { get; set; }
        public byte Flags { get; set; }
        public byte Priority { get; set; }
        public int SpellIconFileId { get; set; }
        public int ActiveIconFileId { get; set; }
        public ushort ViewerUnitConditionId { get; set; }
        public int ViewerPlayerConditionId { get; set; }
        public ushort CasterUnitConditionId { get; set; }
        public int CasterPlayerConditionId { get; set; }
        public int SpellId { get; set; }
    }
}