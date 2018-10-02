using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AreaPOIState, HasIndexInData = false)]
    public class AreaPOIStateEntry
    {
        public string Description { get; set; }
        public byte WorldStateValue { get; set; }
        public byte IconEnumValue { get; set; }
        public int UiTextureAtlasMemberId { get; set; }
        public ushort AreaPoiId { get; set; }
    }
}