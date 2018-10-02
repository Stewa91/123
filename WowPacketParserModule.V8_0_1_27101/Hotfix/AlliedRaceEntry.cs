using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AlliedRace)]
    public class AlliedRaceEntry
    {
        public int ID { get; set; }
        public int RaceId { get; set; }
        public int BannerColor { get; set; }
        public int CrestTextureId { get; set; }
        public int ModelBackgroundTextureId { get; set; }
        public int MaleCreatureDisplayId { get; set; }
        public int FemaleCreatureDisplayId { get; set; }
        public int UiUnlockAchievementId { get; set; }
    }
}