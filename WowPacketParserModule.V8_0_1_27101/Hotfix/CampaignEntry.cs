using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Campaign)]
    public class CampaignEntry
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public uint ID { get; set; }
        public uint UiTextureKitId { get; set; }
        public uint QuestId { get; set; }
        public uint PlayerConditionId { get; set; }
    }
}