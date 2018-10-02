using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GameObjectDisplayInfoXSoundKit, HasIndexInData = false)]
    public class GameObjectDisplayInfoXSoundKitEntry
    {
        public uint SoundKitId { get; set; }
        public byte EventIndex { get; set; }
        public int GameObjectDisplayInfoId { get; set; }
    }
}