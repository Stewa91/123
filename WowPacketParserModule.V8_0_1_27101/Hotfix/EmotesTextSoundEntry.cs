using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.EmotesTextSound, HasIndexInData = false)]
    public class EmotesTextSoundEntry
    {
        public byte RaceId { get; set; }
        public byte ClassId { get; set; }
        public byte SexId { get; set; }
        public uint SoundId { get; set; }
        public ushort EmotesTextId { get; set; }
    }
}