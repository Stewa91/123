using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CharStartOutfit, HasIndexInData = false)]
    public class CharStartOutfitEntry
    {
        public byte ClassId { get; set; }
        public byte SexId { get; set; }
        public byte OutfitId { get; set; }
        public int PetDisplayId { get; set; }
        public byte PetFamilyId { get; set; }
        [HotfixArray(24)]
        public int[] ItemId { get; set; }
        public byte RaceId { get; set; }
    }
}