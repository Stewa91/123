using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ArtifactQuestXP, HasIndexInData = false)]
    public class ArtifactQuestXPEntry
    {
        [HotfixArray(10)]
        public int[] Difficulty { get; set; }
    }
}