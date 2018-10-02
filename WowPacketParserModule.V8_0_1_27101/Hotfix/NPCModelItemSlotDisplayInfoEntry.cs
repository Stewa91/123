using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.NpcModelItemSlotDisplayInfo, HasIndexInData = false)]
    public class NPCModelItemSlotDisplayInfoEntry
    {
        public int ItemDisplayInfoId { get; set; }
        public sbyte ItemSlot { get; set; }
        public int NpcModelId { get; set; }
    }
}