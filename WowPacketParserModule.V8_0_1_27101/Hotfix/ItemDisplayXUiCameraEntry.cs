using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemDisplayXUiCamera, HasIndexInData = false)]
    public class ItemDisplayXUiCameraEntry
    {
        public int ItemDisplayInfoId { get; set; }
        public ushort UiCameraId { get; set; }
    }
}