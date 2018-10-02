using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.DriverBlacklist, HasIndexInData = false)]
    public class DriverBlacklistEntry
    {
        public ushort VendorId { get; set; }
        public byte DeviceId { get; set; }
        public int DriverVersionHi { get; set; }
        public int DriverVersionLow { get; set; }
        public byte OsVersion { get; set; }
        public byte OsBits { get; set; }
        public byte Flags { get; set; }
    }
}