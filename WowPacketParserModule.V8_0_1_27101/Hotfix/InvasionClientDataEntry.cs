using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.InvasionClientData)]
    public class InvasionClientDataEntry
    {
        public string Name { get; set; }
        [HotfixArray(2)]
        public float[] IconLocation { get; set; }
        public int ID { get; set; }
        public int WorldStateId { get; set; }
        public int UiTextureAtlasMemberId { get; set; }
        public int ScenarioId { get; set; }
        public int WorldQuestId { get; set; }
        public int WorldStateValue { get; set; }
        public int InvasionEnabledWorldStateId { get; set; }
        public int AreaTableId { get; set; }
    }
}