using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ComponentTextureFileData, HasIndexInData = false)]
    public class ComponentTextureFileDataEntry
    {
        public byte GenderIndex { get; set; }
        public byte ClassId { get; set; }
        public byte RaceId { get; set; }
    }
}