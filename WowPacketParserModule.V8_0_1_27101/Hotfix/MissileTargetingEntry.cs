using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.MissileTargeting, HasIndexInData = false)]
    public class MissileTargetingEntry
    {
        public float TurnLingering { get; set; }
        public float PitchLingering { get; set; }
        public float MouseLingering { get; set; }
        public float EndOpacity { get; set; }
        public float ArcSpeed { get; set; }
        public float ArcRepeat { get; set; }
        public float ArcWidth { get; set; }
        public float ImpactTexRadius { get; set; }
        public int ArcTextureFileId { get; set; }
        public int ImpactTextureFileId { get; set; }
        [HotfixArray(2)]
        public float[] ImpactRadius { get; set; }
        [HotfixArray(2)]
        public int[] ImpactModelFileId { get; set; }
    }
}