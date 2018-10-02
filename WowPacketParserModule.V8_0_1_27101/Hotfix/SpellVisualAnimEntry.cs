using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellVisualAnim, HasIndexInData = false)]
    public class SpellVisualAnimEntry
    {
        public int InitialAnimId { get; set; }
        public int LoopAnimId { get; set; }
        public ushort AnimKitId { get; set; }
    }
}