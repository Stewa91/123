using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.WMOAreaTable)]
    public class WMOAreaTableEntry
    {
        public string AreaName { get; set; }
        public int ID { get; set; }
        public ushort WmoId { get; set; }
        public byte NameSetId { get; set; }
        public int WmoGroupId { get; set; }
        public byte SoundProviderPref { get; set; }
        public byte SoundProviderPrefUnderwater { get; set; }
        public ushort AmbienceId { get; set; }
        public ushort UwAmbience { get; set; }
        public ushort ZoneMusic { get; set; }
        public int UwZoneMusic { get; set; }
        public ushort IntroSound { get; set; }
        public ushort UwIntroSound { get; set; }
        public ushort AreaTableId { get; set; }
        public byte Flags { get; set; }
    }
}