using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.VirtualAttachmentCustomization, HasIndexInData = false)]
    public class VirtualAttachmentCustomizationEntry
    {
        public ushort VirtualAttachmentId { get; set; }
        public int FileDataId { get; set; }
        public ushort PositionerId { get; set; }
    }
}