using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CreatureDisplayInfoEvt, HasIndexInData = false)]
    public class CreatureDisplayInfoEvtEntry
    {
        public int Fourcc { get; set; }
        public int SpellVisualKitId { get; set; }
        public byte Flags { get; set; }
        public int CreatureDisplayInfoId { get; set; }
    }
}