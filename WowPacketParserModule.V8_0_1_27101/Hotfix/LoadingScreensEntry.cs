using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.LoadingScreens, HasIndexInData = false)]
    public class LoadingScreensEntry
    {
        public int NarrowScreenFileDataId { get; set; }
        public int WideScreenFileDataId { get; set; }
        public int WideScreen169FileDataId { get; set; }
    }
}