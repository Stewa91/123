using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.MountTypeXCapability, HasIndexInData = false)]
    public class MountTypeXCapabilityEntry
    {
        public ushort MountTypeId { get; set; }
        public ushort MountCapabilityId { get; set; }
        public byte OrderIndex { get; set; }
    }
}