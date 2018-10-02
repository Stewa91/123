using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemEffect, HasIndexInData = false)]
    public class ItemEffectEntry
    {
        public byte LegacySlotIndex { get; set; }
        public byte TriggerType { get; set; }
        public ushort Charges { get; set; }
        public uint CoolDownMSec { get; set; }
        public uint CategoryCoolDownMSec { get; set; }
        public ushort SpellCategoryId { get; set; }
        public int SpellId { get; set; }
        public ushort ChrSpecializationId { get; set; }
        public int ParentItemId { get; set; }
    }
}