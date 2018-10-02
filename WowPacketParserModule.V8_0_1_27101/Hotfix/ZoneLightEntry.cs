using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ZoneLight, HasIndexInData = false)]
    public class ZoneLightEntry
    {
        public string Name { get; set; }
        public ushort MapId { get; set; }
        public ushort LightId { get; set; }
        public byte Flags { get; set; }
    }
}