using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.LfgDungeonGroup, HasIndexInData = false)]
    public class LFGDungeonGroupEntry
    {
        public string Name { get; set; }
        public byte Typeid { get; set; }
        public byte ParentGroupId { get; set; }
        public ushort OrderIndex { get; set; }
    }
}