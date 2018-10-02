using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SoundBusOverride)]
    public class SoundBusOverrideEntry
    {
        public int ID { get; set; }
        public int SoundBusId { get; set; }
        public uint PlayerConditionId { get; set; }
        public byte PlaybackLimit { get; set; }
        public float Volume { get; set; }
        public byte Priority { get; set; }
        public byte PriorityPenalty { get; set; }
    }
}