using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.FootstepTerrainLookup, HasIndexInData = false)]
    public class FootstepTerrainLookupEntry
    {
        public ushort CreatureFootstepId { get; set; }
        public byte TerrainSoundId { get; set; }
        public uint SoundId { get; set; }
        public uint SoundIDSplash { get; set; }
    }
}