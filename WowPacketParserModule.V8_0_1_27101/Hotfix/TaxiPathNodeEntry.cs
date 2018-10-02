using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.TaxiPathNode)]
    public class TaxiPathNodeEntry
    {
        [HotfixArray(3)]
        public float[] Loc { get; set; }
        public int ID { get; set; }
        public ushort PathId { get; set; }
        public int NodeIndex { get; set; }
        public ushort ContinentId { get; set; }
        public sbyte Flags { get; set; }
        public int Delay { get; set; }
        public ushort ArrivalEventId { get; set; }
        public ushort DepartureEventId { get; set; }
    }
}