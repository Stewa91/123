using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CreatureDispXUiCamera, HasIndexInData = false)]
    public class CreatureDispXUiCameraEntry
    {
        public int CreatureDisplayInfoId { get; set; }
        public ushort UiCameraId { get; set; }
    }
}