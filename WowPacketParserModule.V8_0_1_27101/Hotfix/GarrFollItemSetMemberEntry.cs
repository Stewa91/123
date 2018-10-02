using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrFollItemSetMember, HasIndexInData = false)]
    public class GarrFollItemSetMemberEntry
    {
        public int ItemId { get; set; }
        public byte ItemSlot { get; set; }
        public ushort MinItemLevel { get; set; }
        public ushort GarrFollItemSetId { get; set; }
    }
}