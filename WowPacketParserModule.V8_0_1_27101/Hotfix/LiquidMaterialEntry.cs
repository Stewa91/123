using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.LiquidMaterial, HasIndexInData = false)]
    public class LiquidMaterialEntry
    {
        public byte Flags { get; set; }
        public byte LVF { get; set; }
    }
}