using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GameObjectDiffAnimMap, HasIndexInData = false)]
    public class GameObjectDiffAnimMapEntry
    {
        public byte DifficultyId { get; set; }
        public byte Animation { get; set; }
        public ushort AttachmentDisplayId { get; set; }
        public byte GameObjectDiffAnimId { get; set; }
    }
}