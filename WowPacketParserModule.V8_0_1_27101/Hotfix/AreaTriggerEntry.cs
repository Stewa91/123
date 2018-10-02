using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AreaTrigger)]
    public class AreaTriggerEntry
    {
        [HotfixArray(3)]
        public float[] Pos { get; set; }
        public int ID { get; set; }
        public ushort ContinentId { get; set; }
        public byte PhaseUseFlags { get; set; }
        public ushort PhaseId { get; set; }
        public ushort PhaseGroupId { get; set; }
        public float Radius { get; set; }
        public float BoxLength { get; set; }
        public float BoxWidth { get; set; }
        public float BoxHeight { get; set; }
        public float BoxYaw { get; set; }
        public byte ShapeType { get; set; }
        public ushort ShapeId { get; set; }
        public ushort AreaTriggerActionSetId { get; set; }
        public byte Flags { get; set; }
    }
}