using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiMapGroupMember, HasIndexInData = false)]
    public class UiMapGroupMemberEntry
    {
        public string Name { get; set; }
        public int UiMapGroupId { get; set; }
        public int UiMapId { get; set; }
        public int FloorIndex { get; set; }
        public byte RelativeHeightIndex { get; set; }
    }
}