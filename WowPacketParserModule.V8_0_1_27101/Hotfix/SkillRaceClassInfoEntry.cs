using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SkillRaceClassInfo, HasIndexInData = false)]
    public class SkillRaceClassInfoEntry
    {
        public ulong RaceMask { get; set; }
        public ushort SkillId { get; set; }
        public int ClassMask { get; set; }
        public ushort Flags { get; set; }
        public byte Availability { get; set; }
        public byte MinLevel { get; set; }
        public ushort SkillTierId { get; set; }
    }
}