using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ChrClassUIDisplay, HasIndexInData = false)]
    public class ChrClassUIDisplayEntry
    {
        public byte ChrClassesId { get; set; }
        public uint AdvGuidePlayerConditionId { get; set; }
        public int SplashPlayerConditionId { get; set; }
    }
}