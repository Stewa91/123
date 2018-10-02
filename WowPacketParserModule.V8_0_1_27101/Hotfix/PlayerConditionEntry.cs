using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.PlayerCondition)]
    public class PlayerConditionEntry
    {
        public ulong RaceMask { get; set; }
        public string FailureDescription { get; set; }
        public int ID { get; set; }
        public ushort MinLevel { get; set; }
        public ushort MaxLevel { get; set; }
        public int ClassMask { get; set; }
        public int SkillLogic { get; set; }
        public byte LanguageId { get; set; }
        public byte MinLanguage { get; set; }
        public int MaxLanguage { get; set; }
        public ushort MaxFactionId { get; set; }
        public byte MaxReputation { get; set; }
        public int ReputationLogic { get; set; }
        public byte CurrentPvpFaction { get; set; }
        public byte PvpMedal { get; set; }
        public int PrevQuestLogic { get; set; }
        public int CurrQuestLogic { get; set; }
        public int CurrentCompletedQuestLogic { get; set; }
        public int SpellLogic { get; set; }
        public int ItemLogic { get; set; }
        public byte ItemFlags { get; set; }
        public int AuraSpellLogic { get; set; }
        public ushort WorldStateExpressionId { get; set; }
        public byte WeatherId { get; set; }
        public byte PartyStatus { get; set; }
        public byte LifetimeMaxPVPRank { get; set; }
        public int AchievementLogic { get; set; }
        public byte Gender { get; set; }
        public byte NativeGender { get; set; }
        public int AreaLogic { get; set; }
        public int LfgLogic { get; set; }
        public int CurrencyLogic { get; set; }
        public ushort QuestKillId { get; set; }
        public int QuestKillLogic { get; set; }
        public byte MinExpansionLevel { get; set; }
        public byte MaxExpansionLevel { get; set; }
        public int MinAvgItemLevel { get; set; }
        public int MaxAvgItemLevel { get; set; }
        public ushort MinAvgEquippedItemLevel { get; set; }
        public ushort MaxAvgEquippedItemLevel { get; set; }
        public byte PhaseUseFlags { get; set; }
        public ushort PhaseId { get; set; }
        public int PhaseGroupId { get; set; }
        public byte Flags { get; set; }
        public byte ChrSpecializationIndex { get; set; }
        public byte ChrSpecializationRole { get; set; }
        public int ModifierTreeId { get; set; }
        public byte PowerType { get; set; }
        public byte PowerTypeComp { get; set; }
        public byte PowerTypeValue { get; set; }
        public int WeaponSubclassMask { get; set; }
        public byte MaxGuildLevel { get; set; }
        public byte MinGuildLevel { get; set; }
        public byte MaxExpansionTier { get; set; }
        public byte MinExpansionTier { get; set; }
        public byte MinPVPRank { get; set; }
        public byte MaxPVPRank { get; set; }
        [HotfixArray(4)]
        public ushort[] SkillId { get; set; }
        [HotfixArray(4)]
        public ushort[] MinSkill { get; set; }
        [HotfixArray(4)]
        public ushort[] MaxSkill { get; set; }
        [HotfixArray(3)]
        public int[] MinFactionId { get; set; }
        [HotfixArray(3)]
        public byte[] MinReputation { get; set; }
        [HotfixArray(4)]
        public ushort[] PrevQuestId { get; set; }
        [HotfixArray(4)]
        public ushort[] CurrQuestId { get; set; }
        [HotfixArray(4)]
        public ushort[] CurrentCompletedQuestId { get; set; }
        [HotfixArray(4)]
        public int[] SpellId { get; set; }
        [HotfixArray(4)]
        public int[] ItemId { get; set; }
        [HotfixArray(4)]
        public int[] ItemCount { get; set; }
        [HotfixArray(2)]
        public ushort[] Explored { get; set; }
        [HotfixArray(2)]
        public int[] Time { get; set; }
        [HotfixArray(4)]
        public int[] AuraSpellId { get; set; }
        [HotfixArray(4)]
        public byte[] AuraStacks { get; set; }
        [HotfixArray(4)]
        public ushort[] Achievement { get; set; }
        [HotfixArray(4)]
        public ushort[] AreaId { get; set; }
        [HotfixArray(4)]
        public byte[] LfgStatus { get; set; }
        [HotfixArray(4)]
        public byte[] LfgCompare { get; set; }
        [HotfixArray(4)]
        public int[] LfgValue { get; set; }
        [HotfixArray(4)]
        public int[] CurrencyId { get; set; }
        [HotfixArray(4)]
        public int[] CurrencyCount { get; set; }
        [HotfixArray(6)]
        public int[] QuestKillMonster { get; set; }
        [HotfixArray(2)]
        public int[] MovementFlags { get; set; }
    }
}