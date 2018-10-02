using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ChrClassVillain, HasIndexInData = false)]
    public class ChrClassVillainEntry
    {
        public string Name { get; set; }
        public byte ChrClassId { get; set; }
        public byte Gender { get; set; }
    }
}