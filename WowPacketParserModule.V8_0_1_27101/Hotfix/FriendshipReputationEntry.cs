using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.FriendshipReputation)]
    public class FriendshipReputationEntry
    {
        public string Description { get; set; }
        public uint ID { get; set; }
        public int TextureFileId { get; set; }
        public ushort FactionId { get; set; }
    }
}