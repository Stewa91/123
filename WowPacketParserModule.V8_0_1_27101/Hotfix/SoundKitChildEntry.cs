using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SoundKitChild, HasIndexInData = false)]
    public class SoundKitChildEntry
    {
        public uint SoundKitId { get; set; }
        public uint ParentSoundKitId { get; set; }
    }
}