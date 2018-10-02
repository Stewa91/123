using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.LfgRoleRequirement, HasIndexInData = false)]
    public class LFGRoleRequirementEntry
    {
        public byte RoleType { get; set; }
        public int PlayerConditionId { get; set; }
        public ushort LfgDungeonsId { get; set; }
    }
}