using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AreaGroupMember, HasIndexInData = false)]
    public class AreaGroupMemberEntry
    {
        public ushort AreaId { get; set; }
        public ushort AreaGroupId { get; set; }
    }
}