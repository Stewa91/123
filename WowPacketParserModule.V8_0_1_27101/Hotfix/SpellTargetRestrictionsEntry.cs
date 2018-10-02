using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellTargetRestrictions, HasIndexInData = false)]
    public class SpellTargetRestrictionsEntry
    {
        public byte DifficultyId { get; set; }
        public float ConeDegrees { get; set; }
        public byte MaxTargets { get; set; }
        public int MaxTargetLevel { get; set; }
        public ushort TargetCreatureType { get; set; }
        public int Targets { get; set; }
        public float Width { get; set; }
        public int SpellId { get; set; }
    }
}