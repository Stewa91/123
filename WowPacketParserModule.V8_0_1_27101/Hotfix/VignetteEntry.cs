using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Vignette, HasIndexInData = false)]
    public class VignetteEntry
    {
        public string Name { get; set; }
        public int PlayerConditionId { get; set; }
        public int VisibleTrackingQuestID { get; set; }
        public int QuestFeedbackEffectId { get; set; }
        public int Flags { get; set; }
        public float MaxHeight { get; set; }
        public float MinHeight { get; set; }
        public byte VignetteType { get; set; }
        public int RewardQuestID { get; set; }
    }
}