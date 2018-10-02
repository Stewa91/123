using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AreaTriggerCreateProperties, HasIndexInData = false)]
    public class AreaTriggerCreatePropertiesEntry
    {
        public byte ShapeType { get; set; }
        public ushort StartShapeId { get; set; }
    }
}