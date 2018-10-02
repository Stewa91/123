using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrFollowerQuality, HasIndexInData = false)]
    public class GarrFollowerQualityEntry
    {
        public byte Quality { get; set; }
        public int XpToNextQuality { get; set; }
        public byte GarrFollowerTypeId { get; set; }
        public byte AbilityCount { get; set; }
        public byte TraitCount { get; set; }
        public ushort ShipmentXP { get; set; }
        public int ClassSpecId { get; set; }
    }
}