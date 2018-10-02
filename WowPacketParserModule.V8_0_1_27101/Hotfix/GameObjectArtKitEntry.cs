using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GameObjectArtKit, HasIndexInData = false)]
    public class GameObjectArtKitEntry
    {
        public int AttachModelFileId { get; set; }
        [HotfixArray(3)]
        public int[] TextureVariationFileId { get; set; }
    }
}