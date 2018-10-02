using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiWidgetDataSource, HasIndexInData = false)]
    public class UiWidgetDataSourceEntry
    {
        public ushort SourceId { get; set; }
        public byte SourceType { get; set; }
        public ushort ReqId { get; set; }
        public int ParentWidgetId { get; set; }
    }
}