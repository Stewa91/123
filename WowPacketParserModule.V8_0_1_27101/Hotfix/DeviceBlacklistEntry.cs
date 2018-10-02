using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.DeviceBlacklist, HasIndexInData = false)]
    public class DeviceBlacklistEntry
    {
        public ushort VendorId { get; set; }
        public ushort DeviceId { get; set; }
    }
}