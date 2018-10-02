using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrTalent)]
    public class GarrTalentEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public uint GarrTalentTreeId { get; set; }
        public byte Tier { get; set; }
        public byte UiOrder { get; set; }
        public int IconFileDataId { get; set; }
        public uint PlayerConditionId { get; set; }
        public int GarrAbilityId { get; set; }
        public int PerkSpellId { get; set; }
        public int PerkPlayerConditionId { get; set; }
        public int ResearchDurationSecs { get; set; }
        public int ResearchGoldCost { get; set; }
        public int ResearchCost { get; set; }
        public uint ResearchCostCurrencyTypesId { get; set; }
        public int RespecDurationSecs { get; set; }
        public int RespecGoldCost { get; set; }
        public int RespecCost { get; set; }
        public uint RespecCostCurrencyTypesId { get; set; }
        public byte Flags { get; set; }
    }
}