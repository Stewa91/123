using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.MultiTransitionProperties, HasIndexInData = false)]
    public class MultiTransitionPropertiesEntry
    {
        public int TransitionType { get; set; }
        public uint DurationMS { get; set; }
        public uint Flags { get; set; }
        public uint StartSpellVisualKitID { get; set; }
        public uint EndSpellVisualKitID { get; set; }
    }
}