using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ScenarioStep, HasIndexInData = false)]
    public class ScenarioStepEntry
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public ushort ScenarioId { get; set; }
        public int CriteriatreeId { get; set; }
        public ushort RewardQuestId { get; set; }
        public int RelatedStep { get; set; }
        public ushort Supersedes { get; set; }
        public byte OrderIndex { get; set; }
        public byte Flags { get; set; }
        public int VisibilityPlayerConditionId { get; set; }
        public ushort WidgetSetID { get; set; }
    }
}