using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ChrUpgradeBucketSpell, HasIndexInData = false)]
    public class ChrUpgradeBucketSpellEntry
    {
        public int SpellId { get; set; }
        public ushort ChrUpgradeBucketId { get; set; }
    }
}