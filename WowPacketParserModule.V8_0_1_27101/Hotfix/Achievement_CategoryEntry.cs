using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Achievement_Category)]
    public class Achievement_CategoryEntry
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public ushort Parent { get; set; }
        public byte UiOrder { get; set; }
    }
}