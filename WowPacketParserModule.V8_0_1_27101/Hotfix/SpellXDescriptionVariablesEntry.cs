using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellXDescriptionVariables, HasIndexInData = false)]
    public class SpellXDescriptionVariablesEntry
    {
        public int SpellId { get; set; }
        public int SpellDescriptionVariablesId { get; set; }
    }
}