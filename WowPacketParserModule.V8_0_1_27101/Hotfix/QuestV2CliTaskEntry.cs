using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.QuestV2CliTask)]
    public class QuestV2CliTaskEntry
    {
        public ulong FiltRaces { get; set; }
        public string QuestTitle { get; set; }
        public string BulletText { get; set; }
        public uint ID { get; set; }
        public ushort UniqueBitFlag { get; set; }
        public int ConditionId { get; set; }
        public int FiltActiveQuest { get; set; }
        public ushort FiltClasses { get; set; }
        public uint FiltCompletedQuestLogic { get; set; }
        public int FiltMaxFactionId { get; set; }
        public int FiltMaxFactionValue { get; set; }
        public uint FiltMaxLevel { get; set; }
        public int FiltMinFactionId { get; set; }
        public int FiltMinFactionValue { get; set; }
        public uint FiltMinLevel { get; set; }
        public uint FiltMinSkillId { get; set; }
        public int FiltMinSkillValue { get; set; }
        public int FiltNonActiveQuest { get; set; }
        public int BreadCrumbId { get; set; }
        public int StartItem { get; set; }
        public ushort WorldStateExpressionId { get; set; }
        public int QuestInfoId { get; set; }
        public int ContentTuningId { get; set; }
        [HotfixArray(3)]
        public int[] FiltCompletedQuest { get; set; }
    }
}