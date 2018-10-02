using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CharacterFacialHairStyles, HasIndexInData = false)]
    public class CharacterFacialHairStylesEntry
    {
        [HotfixArray(5)]
        public uint[] Geoset { get; set; }
        public byte RaceId { get; set; }
        public byte SexId { get; set; }
        public byte VariationId { get; set; }
    }
}