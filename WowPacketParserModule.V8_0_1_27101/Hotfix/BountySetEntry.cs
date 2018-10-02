using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BountySet, HasIndexInData = false)]
    public class BountySetEntry
    {
        public int VisiblePlayerConditionId { get; set; }
        public ushort LockedQuestId { get; set; }
    }
}