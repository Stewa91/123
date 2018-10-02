using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CreatureXDisplayInfo, HasIndexInData = false)]
    public class CreatureXDisplayInfoEntry
    {
        public int CreatureDisplayInfoId { get; set; }
        public float Probability { get; set; }
        public float Scale { get; set; }
        public byte OrderIndex { get; set; }
        public int CreatureId { get; set; }
    }
}