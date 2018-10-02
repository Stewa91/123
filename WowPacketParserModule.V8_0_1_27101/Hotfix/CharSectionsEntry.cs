using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CharSections, HasIndexInData = false)]
    public class CharSectionsEntry
    {
        public byte RaceId { get; set; }
        public byte SexId { get; set; }
        public byte BaseSection { get; set; }
        public byte VariationIndex { get; set; }
        public byte ColorIndex { get; set; }
        public ushort Flags { get; set; }
        [HotfixArray(2)]
        public int[] MaterialResourcesId { get; set; }
    }
}