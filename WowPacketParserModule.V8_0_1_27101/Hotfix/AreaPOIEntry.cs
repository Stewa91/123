using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AreaPOI)]
    public class AreaPOIEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        [HotfixArray(3)]
        public float[] Pos { get; set; }
        public int PortLocId { get; set; }
        public uint PlayerConditionId { get; set; }
        public uint UiTextureAtlasMemberId { get; set; }
        public int Flags { get; set; }
        public int WmoGroupId { get; set; }
        public int PoiDataType { get; set; }
        public int PoiData { get; set; }
        public ushort ContinentId { get; set; }
        public ushort AreaId { get; set; }
        public ushort WorldStateId { get; set; }
        public ushort WidgetSetId { get; set; }
        public byte Importance { get; set; }
        public byte Icon { get; set; }
    }
}
    