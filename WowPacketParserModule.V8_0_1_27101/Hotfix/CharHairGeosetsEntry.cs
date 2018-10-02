using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CharHairGeosets, HasIndexInData = false)]
    public class CharHairGeosetsEntry
    {
        public byte RaceId { get; set; }
        public byte SexId { get; set; }
        public byte VariationId { get; set; }
        public byte GeosetId { get; set; }
        public byte Showscalp { get; set; }
        public byte VariationType { get; set; }
        public byte GeosetType { get; set; }
        public byte ColorIndex { get; set; }
        public int CustomGeoFileDataId { get; set; }
        public int HdCustomGeoFileDataId { get; set; }
    }
}