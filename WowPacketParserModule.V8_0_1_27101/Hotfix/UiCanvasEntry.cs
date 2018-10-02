using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiCanvas)]
    public class UiCanvasEntry
    {
        public int ID { get; set; }
        public ushort Width { get; set; }
        public ushort Height { get; set; }
    }
}