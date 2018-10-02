using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Difficulty, HasIndexInData = false)]
    public class DifficultyEntry
    {
        public string Name { get; set; }
        public byte InstanceType { get; set; }
        public byte OrderIndex { get; set; }
        public byte OldEnumValue { get; set; }
        public byte FallbackDifficultyId { get; set; }
        public byte MinPlayers { get; set; }
        public byte MaxPlayers { get; set; }
        public byte Flags { get; set; }
        public byte ItemContext { get; set; }
        public byte ToggleDifficultyId { get; set; }
        public ushort GroupSizeHealthCurveId { get; set; }
        public ushort GroupSizeDmgCurveId { get; set; }
        public ushort GroupSizeSpellPointsCurveId { get; set; }
    }
}