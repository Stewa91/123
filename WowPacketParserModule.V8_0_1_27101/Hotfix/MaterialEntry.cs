using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Material, HasIndexInData = false)]
    public class MaterialEntry
    {
        public byte Flags { get; set; }
        public uint FoleySoundId { get; set; }
        public int SheatheSoundId { get; set; }
        public int UnsheatheSoundId { get; set; }
    }
}