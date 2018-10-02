using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AreaConditionalData)]
    public class AreaConditionalDataEntry
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int PlayerConditionId { get; set; }
        public int PlayerConditionID { get; set; }
        public int AreaId { get; set; }
    }
}