using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ResearchSite, HasIndexInData = false)]
    public class ResearchSiteEntry
    {
        public string Name { get; set; }
        public ushort MapId { get; set; }
        public int QuestPoiBlobId { get; set; }
        public uint AreaPOIIconEnum { get; set; }
    }
}