using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ChrClassRaceSex, HasIndexInData = false)]
    public class ChrClassRaceSexEntry
    {
        public byte ClassId { get; set; }
        public byte RaceId { get; set; }
        public byte Sex { get; set; }
        public int Flags { get; set; }
        public int SoundId { get; set; }
        public uint VoiceSoundFilterId { get; set; }
    }
}