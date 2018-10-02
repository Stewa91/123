using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SoundKitEntry, HasIndexInData = false)]
    public class SoundKitEntryEntry
    {
        public uint SoundKitId { get; set; }
        public int FileDataId { get; set; }
        public byte Frequency { get; set; }
        public float Volume { get; set; }
    }
}