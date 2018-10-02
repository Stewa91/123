using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.PathNode)]
    public class PathNodeEntry
    {
        public int ID { get; set; }
        public ushort PathId { get; set; }
        public ushort Sequence { get; set; }
        public int LocationId { get; set; }
    }
}