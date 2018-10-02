using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AnimReplacement)]
    public class AnimReplacementEntry
    {
        public int ID { get; set; }
        public ushort SrcAnimId { get; set; }
        public ushort DstAnimId { get; set; }
        public ushort Flags { get; set; }
        public ushort ParentAnimReplacementSetId { get; set; }
    }
}