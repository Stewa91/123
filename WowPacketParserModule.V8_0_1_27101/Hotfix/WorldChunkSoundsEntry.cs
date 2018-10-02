using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.WorldChunkSounds, HasIndexInData = false)]
    public class WorldChunkSoundsEntry
    {
        public ushort MapId { get; set; }
        public byte SoundOverrideId { get; set; }
        public byte ChunkX { get; set; }
        public byte ChunkY { get; set; }
        public byte SubChunkX { get; set; }
        public byte SubChunkY { get; set; }
    }
}