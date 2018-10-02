using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BattlePetBreedState, HasIndexInData = false)]
    public class BattlePetBreedStateEntry
    {
        public byte BattlePetStateId { get; set; }
        public ushort Value { get; set; }
        public byte BattlePetBreedId { get; set; }
    }
}