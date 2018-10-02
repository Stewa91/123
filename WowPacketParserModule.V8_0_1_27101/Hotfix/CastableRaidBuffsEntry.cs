using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CastableRaidBuffs, HasIndexInData = false)]
    public class CastableRaidBuffsEntry
    {
        public uint CastingSpellId { get; set; }
        public int SpellId { get; set; }
    }
}