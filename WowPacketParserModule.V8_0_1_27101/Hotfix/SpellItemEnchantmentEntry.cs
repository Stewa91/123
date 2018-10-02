using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellItemEnchantment, HasIndexInData = false)]
    public class SpellItemEnchantmentEntry
    {
        public string Name { get; set; }
        public string HordeName { get; set; }
        [HotfixArray(3)]
        public int[] EffectArg { get; set; }
        [HotfixArray(3)]
        public float[] EffectScalingPoints { get; set; }
        public int TransmogCost { get; set; }
        public int IconFileDataId { get; set; }
        public uint TransmogPlayerConditionId { get; set; }
        [HotfixArray(3)]
        public ushort[] EffectPointsMin { get; set; }
        public ushort ItemVisual { get; set; }
        public ushort Flags { get; set; }
        public ushort RequiredSkillId { get; set; }
        public ushort RequiredSkillRank { get; set; }
        public ushort ItemLevel { get; set; }
        public byte Charges { get; set; }
        [HotfixArray(3)]
        public byte[] Effect { get; set; }
        public byte ScalingClass { get; set; }
        public byte ScalingClassRestricted { get; set; }
        public byte ConditionId { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
    }
}