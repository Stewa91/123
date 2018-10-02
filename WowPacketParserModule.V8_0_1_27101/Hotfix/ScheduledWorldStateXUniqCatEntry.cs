using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ScheduledWorldStateXUniqCat)]
    public class ScheduledWorldStateXUniqCatEntry
    {
        public int ID { get; set; }
        public int ScheduledUniqueCategoryId { get; set; }
        public int ScheduledWorldStateId { get; set; }
    }
}