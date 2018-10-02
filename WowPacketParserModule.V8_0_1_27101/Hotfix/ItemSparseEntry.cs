using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemSparse, HasIndexInData = false)]
    public class ItemSparseEntry
    {
        public ulong AllowableRace { get; set; }
        public string Description { get; set; }
        public string Display3 { get; set; }
        public string Display2 { get; set; }
        public string Display1 { get; set; }
        public string Display { get; set; }
        public float DmgVariance { get; set; }
        public int DurationInInventory { get; set; }
        public float QualityModifier { get; set; }
        public int BagFamily { get; set; }
        public float ItemRange { get; set; }
        [HotfixArray(10)]
        public float[] StatPercentageOfSocket { get; set; }
        [HotfixArray(10)]
        public int[] StatPercentEditor { get; set; }
        public int Stackable { get; set; }
        public int MaxCount { get; set; }
        public int RequiredAbility { get; set; }
        public int SellPrice { get; set; }
        public int BuyPrice { get; set; }
        public int VendorStackCount { get; set; }
        public float PriceVariance { get; set; }
        public float PriceRandomValue { get; set; }
        [HotfixArray(4)]
        public uint[] Flags { get; set; }
        public int OppositeFactionItemID { get; set; }
        public ushort ItemNameDescriptionId { get; set; }
        public ushort RequiredTransmogHoliday { get; set; }
        public ushort RequiredHoliday { get; set; }
        public ushort LimitCategory { get; set; }
        public ushort GemProperties { get; set; }
        public ushort SocketMatchEnchantmentId { get; set; }
        public ushort TotemCategoryId { get; set; }
        public ushort InstanceBound { get; set; }
        public ushort ZoneBound { get; set; }
        public ushort ItemSet { get; set; }
        public ushort ItemRandomSuffixGroupId { get; set; }
        public ushort RandomSelect { get; set; }
        public ushort LockId { get; set; }
        public ushort StartQuestId { get; set; }
        public ushort PageId { get; set; }
        public ushort ItemDelay { get; set; }
        public ushort ScalingStatDistributionId { get; set; }
        public ushort MinFactionId { get; set; }
        public ushort RequiredSkillRank { get; set; }
        public ushort RequiredSkill { get; set; }
        public ushort ItemLevel { get; set; }
        public ushort AllowableClass { get; set; }
        public byte ExpansionId { get; set; }
        public byte ArtifactId { get; set; }
        public byte SpellWeight { get; set; }
        public byte SpellWeightCategory { get; set; }
        [HotfixArray(3)]
        public byte[] SocketType { get; set; }
        public byte SheatheType { get; set; }
        public byte Material { get; set; }
        public byte PageMaterialId { get; set; }
        public byte LanguageId { get; set; }
        public byte Bonding { get; set; }
        public byte DamageDamageType { get; set; }
        [HotfixArray(10)]
        public byte[] StatModifierBonusStat { get; set; }
        public byte ContainerSlots { get; set; }
        public byte MinReputation { get; set; }
        public byte RequiredPVPMedal { get; set; }
        public byte RequiredPVPRank { get; set; }
        public byte RequiredLevel { get; set; }
        public byte InventoryType { get; set; }
        public byte OverallQualityId { get; set; }
    }
}
    