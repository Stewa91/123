using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrFollower)]
    public class GarrFollowerEntry
    {
        public string HordeSourceText { get; set; }
        public string AllianceSourceText { get; set; }
        public string TitleName { get; set; }
        public int ID { get; set; }
        public byte GarrTypeId { get; set; }
        public byte GarrFollowerTypeId { get; set; }
        public int HordeCreatureId { get; set; }
        public int AllianceCreatureId { get; set; }
        public byte HordeGarrFollRaceId { get; set; }
        public byte AllianceGarrFollRaceId { get; set; }
        public byte HordeGarrClassSpecId { get; set; }
        public byte AllianceGarrClassSpecId { get; set; }
        public byte Quality { get; set; }
        public byte FollowerLevel { get; set; }
        public ushort ItemLevelWeapon { get; set; }
        public ushort ItemLevelArmor { get; set; }
        public byte HordeSourceTypeEnum { get; set; }
        public byte AllianceSourceTypeEnum { get; set; }
        public int HordeIconFileDataId { get; set; }
        public int AllianceIconFileDataId { get; set; }
        public ushort HordeGarrFollItemSetId { get; set; }
        public ushort AllianceGarrFollItemSetId { get; set; }
        public ushort HordeUITextureKitId { get; set; }
        public ushort AllianceUITextureKitId { get; set; }
        public byte Vitality { get; set; }
        public byte HordeFlavorGarrStringId { get; set; }
        public byte AllianceFlavorGarrStringId { get; set; }
        public int HordeSlottingBroadcastTextId { get; set; }
        public int AllySlottingBroadcastTextId { get; set; }
        public byte ChrClassId { get; set; }
        public byte Flags { get; set; }
        public byte Gender { get; set; }
    }
}