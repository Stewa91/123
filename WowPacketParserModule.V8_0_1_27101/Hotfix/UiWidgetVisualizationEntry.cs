using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiWidgetVisualization, HasIndexInData = false)]
    public class UiWidgetVisualizationEntry
    {
        public byte VisType { get; set; }
        public int TextureKit { get; set; }
        public int FrameTextureKit { get; set; }
        public ushort WidgetWidth { get; set; }
    }
}