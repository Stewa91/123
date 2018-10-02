using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.FactionGroup)]
    public class FactionGroupEntry
    {
        public string InternalName { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public byte MaskId { get; set; }
        public int HonorCurrencyTextureFileId { get; set; }
        public int ConquestCurrencyTextureFileId { get; set; }
    }
}