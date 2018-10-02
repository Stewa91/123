using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BattlemasterList, HasIndexInData = false)]
    public class BattlemasterListEntry
    {
        public string Name { get; set; }
        public string GameType { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public byte InstanceType { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public byte RatedPlayers { get; set; }
        public byte MinPlayers { get; set; }
        public byte MaxPlayers { get; set; }
        public byte GroupsAllowed { get; set; }
        public byte MaxGroupSize { get; set; }
        public ushort HolidayWorldState { get; set; }
        public byte Flags { get; set; }
        public int IconFileDataId { get; set; }
        public ushort RequiredPlayerConditionId { get; set; }
        [HotfixArray(16)]
        public ushort[] MapId { get; set; }
    }
}