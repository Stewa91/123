using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiWidgetConstantSource, HasIndexInData = false)]
    public class UiWidgetConstantSourceEntry
    {
        public ushort ReqId { get; set; }
        public int Value { get; set; }
        public int ParentWidgetId { get; set; }
    }
}