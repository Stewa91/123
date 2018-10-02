using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ModelAnimCloakDampening, HasIndexInData = false)]
    public class ModelAnimCloakDampeningEntry
    {
        public int AnimationDataId { get; set; }
        public uint CloakDampeningId { get; set; }
        public uint FileDataId { get; set; }
    }
}