using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.LfgDungeons, HasIndexInData = false)]
    public class LFGDungeonsEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte MinLevel { get; set; }
        public ushort MaxLevel { get; set; }
        public byte TypeId { get; set; }
        public byte Subtype { get; set; }
        public byte Faction { get; set; }
        public int IconTextureFileId { get; set; }
        public int RewardsBgTextureFileId { get; set; }
        public int PopupBgTextureFileId { get; set; }
        public byte ExpansionLevel { get; set; }
        public ushort MapId { get; set; }
        public byte DifficultyId { get; set; }
        public float MinGear { get; set; }
        public byte GroupId { get; set; }
        public byte OrderIndex { get; set; }
        public int RequiredPlayerConditionId { get; set; }
        public byte TargetLevel { get; set; }
        public byte TargetLevelMin { get; set; }
        public ushort TargetLevelMax { get; set; }
        public ushort RandomId { get; set; }
        public ushort ScenarioId { get; set; }
        public ushort FinalEncounterId { get; set; }
        public byte CountTank { get; set; }
        public byte CountHealer { get; set; }
        public byte CountDamage { get; set; }
        public byte MinCountTank { get; set; }
        public byte MinCountHealer { get; set; }
        public byte MinCountDamage { get; set; }
        public ushort BonusReputationAmount { get; set; }
        public ushort MentorItemLevel { get; set; }
        public byte MentorCharLevel { get; set; }
        [HotfixArray(2)]
        public int[] Flags { get; set; }
    }
}