using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.DeathThudLookups, HasIndexInData = false)]
    public class DeathThudLookupsEntry
    {
        public byte SizeClass { get; set; }
        public byte TerrainTypeSoundId { get; set; }
        public uint SoundEntryId { get; set; }
        public int SoundEntryIDWater { get; set; }
    }
}