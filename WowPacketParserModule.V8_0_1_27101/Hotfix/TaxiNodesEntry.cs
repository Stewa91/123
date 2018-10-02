using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.TaxiNodes)]
    public class TaxiNodesEntry
    {
        public string Name { get; set; }
        [HotfixArray(3)]
        public float[] Pos { get; set; }
        [HotfixArray(2)]
        public float[] MapOffset { get; set; }
        [HotfixArray(2)]
        public float[] FlightMapOffset { get; set; }
        public int ID { get; set; }
        public ushort ContinentId { get; set; }
        public ushort ConditionId { get; set; }
        public ushort CharacterBitNumber { get; set; }
        public byte Flags { get; set; }
        public int UiTextureKitId { get; set; }
        public float Facing { get; set; }
        public int SpecialIconConditionId { get; set; }
        [HotfixArray(2)]
        public int[] MountCreatureId { get; set; }
    }
}