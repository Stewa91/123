using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrFollowerUICreature, HasIndexInData = false)]
    public class GarrFollowerUICreatureEntry
    {
        public byte OrderIndex { get; set; }
        public byte FactionIndex { get; set; }
        public int CreatureId { get; set; }
        public float Scale { get; set; }
        public byte Flags { get; set; }
        public ushort GarrFollowerId { get; set; }
    }
}