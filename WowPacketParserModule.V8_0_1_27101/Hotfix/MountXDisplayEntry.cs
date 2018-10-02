using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.MountXDisplay, HasIndexInData = false)]
    public class MountXDisplayEntry
    {
        public int CreatureDisplayInfoId { get; set; }
        public int PlayerConditionId { get; set; }
        public int MountId { get; set; }
    }
}