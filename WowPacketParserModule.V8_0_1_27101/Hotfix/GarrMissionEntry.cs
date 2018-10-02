using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrMission)]
    public class GarrMissionEntry
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        [HotfixArray(2)]
        public float[] MapPos { get; set; }
        [HotfixArray(2)]
        public float[] WorldPos { get; set; }
        public int ID { get; set; }
        public byte GarrTypeId { get; set; }
        public byte GarrMissionTypeId { get; set; }
        public byte GarrFollowerTypeId { get; set; }
        public byte MaxFollowers { get; set; }
        public int MissionCost { get; set; }
        public ushort MissionCostCurrencyTypesId { get; set; }
        public byte OfferedGarrMissionTextureId { get; set; }
        public ushort UiTextureKitId { get; set; }
        public int EnvGarrMechanicId { get; set; }
        public byte EnvGarrMechanicTypeId { get; set; }
        public int PlayerConditionId { get; set; }
        public byte TargetLevel { get; set; }
        public ushort TargetItemLevel { get; set; }
        public int MissionDuration { get; set; }
        public int TravelDuration { get; set; }
        public int OfferDuration { get; set; }
        public byte BaseCompletionChance { get; set; }
        public int BaseFollowerXP { get; set; }
        public int OvermaxRewardPackId { get; set; }
        public byte FollowerDeathChance { get; set; }
        public int AreaId { get; set; }
        public int Flags { get; set; }
        public int GarrMissionSetId { get; set; }
    }
}