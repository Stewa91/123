using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Toy)]
    public class ToyEntry
    {
        public string SourceText { get; set; }
        public int ID { get; set; }
        public int ItemId { get; set; }
        public byte Flags { get; set; }
        public byte SourceTypeEnum { get; set; }
    }
}