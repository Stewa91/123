using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CharacterLoadout, HasIndexInData = false)]
    public class CharacterLoadoutEntry
    {
        public ulong RaceMask { get; set; }
        public byte ChrClassId { get; set; }
        public byte Purpose { get; set; }
    }
}