using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiWidget, HasIndexInData = false)]
    public class UiWidgetEntry
    {
        public string WidgetTag { get; set; }
        public ushort ParentSetId { get; set; }
        public int VisId { get; set; }
        public int MapId { get; set; }
        public int PlayerConditionId { get; set; }
        public int OrderIndex { get; set; }
    }
}
    