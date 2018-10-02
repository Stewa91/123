using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CreatureDisplayInfoExtra, HasIndexInData = false)]
    public class CreatureDisplayInfoExtraEntry
    {
        public byte DisplayRaceId { get; set; }
        public byte DisplaySexId { get; set; }
        public byte DisplayClassId { get; set; }
        public byte SkinId { get; set; }
        public byte FaceId { get; set; }
        public byte HairStyleId { get; set; }
        public byte HairColorId { get; set; }
        public byte FacialHairId { get; set; }
        public byte Flags { get; set; }
        public int BakeMaterialResourcesId { get; set; }
        public int HDBakeMaterialResourcesId { get; set; }
        [HotfixArray(3)]
        public byte[] CustomDisplayOption { get; set; }
    }
}