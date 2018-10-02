using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CharShipmentContainer, HasIndexInData = false)]
    public class CharShipmentContainerEntry
    {
        public string Description { get; set; }
        public string PendingText { get; set; }
        public ushort UiTextureKitId { get; set; }
        public byte GarrTypeId { get; set; }
        public byte GarrBuildingType { get; set; }
        public byte BaseCapacity { get; set; }
        public ushort SmallDisplayInfoId { get; set; }
        public ushort MediumDisplayInfoId { get; set; }
        public ushort LargeDisplayInfoId { get; set; }
        public ushort WorkingDisplayInfoId { get; set; }
        public int WorkingSpellVisualId { get; set; }
        public uint CompleteSpellVisualId { get; set; }
        public byte MediumThreshold { get; set; }
        public byte LargeThreshold { get; set; }
        public byte Faction { get; set; }
        public ushort CrossFactionId { get; set; }
    }
}