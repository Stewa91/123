using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SoundFilterElem, HasIndexInData = false)]
    public class SoundFilterElemEntry
    {
        [HotfixArray(9)]
        public float[] Params { get; set; }
        public byte FilterType { get; set; }
        public byte SoundFilterId { get; set; }
    }
}