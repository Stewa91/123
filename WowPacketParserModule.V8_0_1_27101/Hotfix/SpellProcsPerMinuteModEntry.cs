using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellProcsPerMinuteMod, HasIndexInData = false)]
    public class SpellProcsPerMinuteModEntry
    {
        public byte Type { get; set; }
        public ushort Param { get; set; }
        public float Coeff { get; set; }
        public ushort SpellProcsPerMinuteId { get; set; }
    }
}