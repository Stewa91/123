using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Movie, HasIndexInData = false)]
    public class MovieEntry
    {
        public byte Volume { get; set; }
        public byte KeyId { get; set; }
        public int AudioFileDataId { get; set; }
        public int SubtitleFileDataId { get; set; }
    }
}