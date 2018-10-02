using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.JournalInstance)]
    public class JournalInstanceEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public ushort MapId { get; set; }
        public int BackgroundFileDataId { get; set; }
        public int ButtonFileDataId { get; set; }
        public int ButtonSmallFileDataId { get; set; }
        public int LoreFileDataId { get; set; }
        public byte OrderIndex { get; set; }
        public byte Flags { get; set; }
        public ushort AreaId { get; set; }
    }
}