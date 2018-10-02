using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CriteriaTree, HasIndexInData = false)]
    public class CriteriaTreeEntry
    {
        public string Description { get; set; }
        public uint Parent { get; set; }
        public int Amount { get; set; }
        public byte Operator { get; set; }
        public uint CriteriaId { get; set; }
        public int OrderIndex { get; set; }
        public ushort Flags { get; set; }
    }
}