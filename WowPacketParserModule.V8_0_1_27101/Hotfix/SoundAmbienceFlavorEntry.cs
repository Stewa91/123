using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SoundAmbienceFlavor, HasIndexInData = false)]
    public class SoundAmbienceFlavorEntry
    {
        public int SoundEntriesIDDay { get; set; }
        public uint SoundEntriesIDNight { get; set; }
        public ushort SoundAmbienceId { get; set; }
    }
}