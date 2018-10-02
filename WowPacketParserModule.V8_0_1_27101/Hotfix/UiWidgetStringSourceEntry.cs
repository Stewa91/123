using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiWidgetStringSource, HasIndexInData = false)]
    public class UiWidgetStringSourceEntry
    {
        public string Value { get; set; }
        public ushort ReqId { get; set; }
        public int ParentWidgetId { get; set; }
    }
}