using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrBuilding, HasIndexInData = false)]
    public class GarrBuildingEntry
    {
        public string HordeName { get; set; }
        public string AllianceName { get; set; }
        public string Description { get; set; }
        public string Tooltip { get; set; }
        public byte GarrTypeId { get; set; }
        public byte BuildingType { get; set; }
        public int HordeGameObjectId { get; set; }
        public int AllianceGameObjectId { get; set; }
        public byte GarrSiteId { get; set; }
        public byte UpgradeLevel { get; set; }
        public int BuildSeconds { get; set; }
        public ushort CurrencyTypeId { get; set; }
        public int CurrencyQty { get; set; }
        public ushort HordeUiTextureKitId { get; set; }
        public ushort AllianceUiTextureKitId { get; set; }
        public int IconFileDataId { get; set; }
        public ushort AllianceSceneScriptPackageId { get; set; }
        public ushort HordeSceneScriptPackageId { get; set; }
        public int MaxAssignments { get; set; }
        public byte ShipmentCapacity { get; set; }
        public ushort GarrAbilityId { get; set; }
        public ushort BonusGarrAbilityId { get; set; }
        public ushort GoldCost { get; set; }
        public byte Flags { get; set; }
    }
}