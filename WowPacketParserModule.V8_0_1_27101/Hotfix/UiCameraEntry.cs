using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiCamera, HasIndexInData = false)]
    public class UiCameraEntry
    {
        public string Name { get; set; }
        [HotfixArray(3)]
        public float[] Pos { get; set; }
        [HotfixArray(3)]
        public float[] LookAt { get; set; }
        [HotfixArray(3)]
        public float[] Up { get; set; }
        public byte UiCameraTypeId { get; set; }
        public int AnimId { get; set; }
        public ushort AnimFrame { get; set; }
        public byte AnimVariation { get; set; }
        public byte Flags { get; set; }
    }
}