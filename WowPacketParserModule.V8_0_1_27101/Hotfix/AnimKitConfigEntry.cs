using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AnimKitConfig, HasIndexInData = false)]
    public class AnimKitConfigEntry
    {
        public int ConfigFlags { get; set; }
    }
}