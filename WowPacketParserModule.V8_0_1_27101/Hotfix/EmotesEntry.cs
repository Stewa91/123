using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Emotes, HasIndexInData = false)]
    public class EmotesEntry
    {
        public ulong RaceMask { get; set; }
        public string EmoteSlashCommand { get; set; }
        public uint AnimId { get; set; }
        public int EmoteFlags { get; set; }
        public byte EmoteSpecProc { get; set; }
        public uint EmoteSpecProcParam { get; set; }
        public uint EventSoundId { get; set; }
        public int SpellVisualKitId { get; set; }
        public int ClassMask { get; set; }
    }
}