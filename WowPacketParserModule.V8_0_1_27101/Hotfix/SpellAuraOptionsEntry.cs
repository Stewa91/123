using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellAuraOptions, HasIndexInData = false)]
    public class SpellAuraOptionsEntry
    {
        public byte DifficultyId { get; set; }
        public ushort CumulativeAura { get; set; }
        public int ProcCategoryRecovery { get; set; }
        public byte ProcChance { get; set; }
        public int ProcCharges { get; set; }
        public ushort SpellProcsPerMinuteId { get; set; }
        [HotfixArray(2)]
        public uint[] ProcTypeMask { get; set; }
        public int SpellId { get; set; }
    }
}