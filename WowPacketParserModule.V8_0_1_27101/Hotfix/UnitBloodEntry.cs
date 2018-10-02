using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UnitBlood, HasIndexInData = false)]
    public class UnitBloodEntry
    {
        public uint PlayerCritBloodSpurtId { get; set; }
        public int PlayerHitBloodSpurtId { get; set; }
        public int DefaultBloodSpurtId { get; set; }
        public int PlayerOmniCritBloodSpurtId { get; set; }
        public uint PlayerOmniHitBloodSpurtId { get; set; }
        public int DefaultOmniBloodSpurtId { get; set; }
    }
}