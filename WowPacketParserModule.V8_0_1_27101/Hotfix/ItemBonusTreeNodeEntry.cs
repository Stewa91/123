using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemBonusTreeNode, HasIndexInData = false)]
    public class ItemBonusTreeNodeEntry
    {
        public byte ItemContext { get; set; }
        public ushort ChildItemBonusTreeId { get; set; }
        public ushort ChildItemBonusListId { get; set; }
        public ushort ChildItemLevelSelectorId { get; set; }
        public ushort ParentItemBonusTreeId { get; set; }
    }
}