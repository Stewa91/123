using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrClassSpec)]
    public class GarrClassSpecEntry
    {
        public string ClassSpec { get; set; }
        public string ClassSpecMale { get; set; }
        public string ClassSpecFemale { get; set; }
        public uint ID { get; set; }
        public ushort UiTextureAtlasMemberId { get; set; }
        public ushort GarrFollItemSetId { get; set; }
        public byte FollowerClassLimit { get; set; }
        public byte Flags { get; set; }
    }
}