using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CharacterFaceBoneSet, HasIndexInData = false)]
    public class CharacterFaceBoneSetEntry
    {
        public byte SexId { get; set; }
        public int ModelFileDataId { get; set; }
        public byte FaceVariationIndex { get; set; }
        public int BoneSetFileDataId { get; set; }
        public byte RaceId { get; set; }
    }
}