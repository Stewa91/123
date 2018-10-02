using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CommentatorTrackedCooldown, HasIndexInData = false)]
    public class CommentatorTrackedCooldownEntry
    {
        public int SpellId { get; set; }
        public byte Priority { get; set; }
        public byte Flags { get; set; }
        public ushort ChrSpecId { get; set; }
    }
}