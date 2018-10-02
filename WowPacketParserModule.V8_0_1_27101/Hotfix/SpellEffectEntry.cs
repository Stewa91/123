using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellEffect, HasIndexInData = false)]
    public class SpellEffectEntry
    {
        public int DifficultyId { get; set; }
        public int EffectIndex { get; set; }
        public uint Effect { get; set; }
        public float EffectAmplitude { get; set; }
        public uint EffectAttributes { get; set; }
        public ushort EffectAura { get; set; }
        public uint EffectAuraPeriod { get; set; }
        public float EffectBonusCoefficient { get; set; }
        public float EffectChainAmplitude { get; set; }
        public uint EffectChainTargets { get; set; }
        public int EffectItemType { get; set; }
        public int EffectMechanic { get; set; }
        public float EffectPointsPerResource { get; set; }
        public float EffectPosFacing { get; set; }
        public float EffectRealPointsPerLevel { get; set; }
        public uint EffectTriggerSpell { get; set; }
        public float BonusCoefficientFromAP { get; set; }
        public float PvpMultiplier { get; set; }
        public float Coefficient { get; set; }
        public float Variance { get; set; }
        public float ResourceCoefficient { get; set; }
        public float GroupSizeBasePointsCoefficient { get; set; }
        public float EffectBasePoints { get; set; }
        [HotfixArray(2)]
        public uint[] EffectMiscValue { get; set; }
        [HotfixArray(2)]
        public uint[] EffectRadiusIndex { get; set; }
        [HotfixArray(4)]
        public uint[] EffectSpellClassMask { get; set; }
        [HotfixArray(2)]
        public ushort[] ImplicitTarget { get; set; }
        public int SpellId { get; set; }
    }
}