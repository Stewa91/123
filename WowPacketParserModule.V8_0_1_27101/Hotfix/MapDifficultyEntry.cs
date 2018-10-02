using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.MapDifficulty, HasIndexInData = false)]
    public class MapDifficultyEntry
    {
        public string Message { get; set; }
        public int ItemContextPickerId { get; set; }
        public int ContentTuningID { get; set; }
        public byte DifficultyId { get; set; }
        public byte LockId { get; set; }
        public byte ResetInterval { get; set; }
        public byte MaxPlayers { get; set; }
        public byte ItemContext { get; set; }
        public byte Flags { get; set; }
        public ushort MapId { get; set; }
    }
}