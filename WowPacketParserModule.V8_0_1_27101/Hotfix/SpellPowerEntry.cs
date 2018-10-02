using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellPower)]
    public class SpellPowerEntry
    {
        public int ID { get; set; }
        public byte OrderIndex { get; set; }
        public int ManaCost { get; set; }
        public int ManaCostPerLevel { get; set; }
        public int ManaPerSecond { get; set; }
        public int PowerDisplayId { get; set; }
        public int AltPowerBarId { get; set; }
        public float PowerCostPct { get; set; }
        public float PowerCostMaxPct { get; set; }
        public float PowerPctPerSecond { get; set; }
        public byte PowerType { get; set; }
        public int RequiredAuraSpellId { get; set; }
        public int OptionalCost { get; set; }
        public int SpellId { get; set; }
    }
}