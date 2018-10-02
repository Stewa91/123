using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.PvpTier, HasIndexInData = false)]
    public class PvpTierEntry
    {
        public string Name { get; set; }
        public ushort DescendRating { get; set; }
        public ushort AscendRating { get; set; }
        public int DescendTier { get; set; }
        public int AscendTier { get; set; }
        public byte Type { get; set; }
        public byte TierEnumId { get; set; }
        public int TierIconFileDataId { get; set; }
    }
}