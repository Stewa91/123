using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemRangedDisplayInfo, HasIndexInData = false)]
    public class ItemRangedDisplayInfoEntry
    {
        public uint CastSpellVisualId { get; set; }
        public int AutoAttackSpellVisualId { get; set; }
        public uint QuiverFileDataId { get; set; }
        public int MissileSpellVisualEffectNameId { get; set; }
    }
}