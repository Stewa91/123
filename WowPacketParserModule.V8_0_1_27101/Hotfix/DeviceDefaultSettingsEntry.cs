using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.DeviceDefaultSettings, HasIndexInData = false)]
    public class DeviceDefaultSettingsEntry
    {
        public ushort VendorId { get; set; }
        public ushort DeviceId { get; set; }
        public byte DefaultSetting { get; set; }
    }
}