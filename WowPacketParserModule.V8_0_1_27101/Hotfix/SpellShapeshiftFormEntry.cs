using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellShapeshiftForm, HasIndexInData = false)]
    public class SpellShapeshiftFormEntry
    {
        public string Name { get; set; }
        public byte CreatureType { get; set; }
        public int Flags { get; set; }
        public int AttackIconFileId { get; set; }
        public byte BonusActionBar { get; set; }
        public ushort CombatRoundTime { get; set; }
        public float DamageVariance { get; set; }
        public ushort MountTypeId { get; set; }
        [HotfixArray(4)]
        public int[] CreatureDisplayId { get; set; }
        [HotfixArray(8)]
        public int[] PresetSpellId { get; set; }
    }
}