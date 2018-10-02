using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BattlePetDisplayOverride, HasIndexInData = false)]
    public class BattlePetDisplayOverrideEntry
    {
        public uint BattlePetSpeciesId { get; set; }
        public int PlayerConditionId { get; set; }
        public int CreatureDisplayInfoId { get; set; }
        public byte PriorityCategory { get; set; }
    }
}