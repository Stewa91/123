using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BattlePetSpeciesState, HasIndexInData = false)]
    public class BattlePetSpeciesStateEntry
    {
        public byte BattlePetStateId { get; set; }
        public uint Value { get; set; }
        public ushort BattlePetSpeciesId { get; set; }
    }
}