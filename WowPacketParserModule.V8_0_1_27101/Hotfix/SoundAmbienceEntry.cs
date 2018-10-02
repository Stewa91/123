using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SoundAmbience, HasIndexInData = false)]
    public class SoundAmbienceEntry
    {
        public byte Flags { get; set; }
        public uint SoundFilterId { get; set; }
        public uint FlavorSoundFilterId { get; set; }
        [HotfixArray(2)]
        public int[] AmbienceId { get; set; }
        [HotfixArray(2)]
        public int[] AmbienceStartId { get; set; }
        [HotfixArray(2)]
        public int[] AmbienceStopId { get; set; }
    }
}