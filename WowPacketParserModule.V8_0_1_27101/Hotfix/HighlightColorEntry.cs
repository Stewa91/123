using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.HighlightColor, HasIndexInData = false)]
    public class HighlightColorEntry
    {
        public byte Type { get; set; }
        public uint StartColor { get; set; }
        public uint MidColor { get; set; }
        public int EndColor { get; set; }
        public byte Flags { get; set; }
    }
}