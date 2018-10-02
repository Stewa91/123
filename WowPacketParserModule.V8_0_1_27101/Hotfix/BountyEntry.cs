using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Bounty, HasIndexInData = false)]
    public class BountyEntry
    {
        public ushort QuestId { get; set; }
        public ushort FactionId { get; set; }
        public int IconFileDataId { get; set; }
        public uint TurninPlayerConditionId { get; set; }
        public byte BountySetId { get; set; }
    }
}