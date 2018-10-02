using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AzeriteItemMilestonePower, HasIndexInData = false)]
    public class AzeriteItemMilestonePowerEntry
    {
        public byte RequiredLevel { get; set; }
        public ushort AzeritePowerId { get; set; }
    }
}