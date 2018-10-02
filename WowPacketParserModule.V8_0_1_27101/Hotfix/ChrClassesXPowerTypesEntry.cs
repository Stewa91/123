using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ChrClassesXPowerTypes, HasIndexInData = false)]
    public class ChrClassesXPowerTypesEntry
    {
        public byte PowerType { get; set; }
        public byte ClassId { get; set; }
    }
}