using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AreaTable, HasIndexInData = false)]
    public class AreaTableEntry
    {
        public string ZoneName { get; set; }
        public string AreaName { get; set; }
        public ushort ContinentId { get; set; }
        public ushort ParentAreaId { get; set; }
        public ushort AreaBit { get; set; }
        public byte SoundProviderPref { get; set; }
        public byte SoundProviderPrefUnderwater { get; set; }
        public ushort AmbienceId { get; set; }
        public ushort UwAmbience { get; set; }
        public ushort ZoneMusic { get; set; }
        public ushort UwZoneMusic { get; set; }
        public byte ExplorationLevel { get; set; }
        public ushort IntroSound { get; set; }
        public int UwIntroSound { get; set; }
        public byte FactionGroupMask { get; set; }
        public float AmbientMultiplier { get; set; }
        public byte MountFlags { get; set; }
        public ushort PvpCombatWorldStateId { get; set; }
        public byte WildBattlePetLevelMin { get; set; }
        public byte WildBattlePetLevelMax { get; set; }
        public byte WindSettingsId { get; set; }
        [HotfixArray(2)]
        public int[] Flags { get; set; }
        [HotfixArray(4)]
        public ushort[] LiquidTypeId { get; set; }
    }
}