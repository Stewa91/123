using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ChrRaces)]
    public class ChrRacesEntry
    {
        public string ClientPrefix { get; set; }
        public string ClientFileString { get; set; }
        public string Name { get; set; }
        public string NameFemale { get; set; }
        public string NameLowercase { get; set; }
        public string NameFemaleLowercase { get; set; }
        public int ID { get; set; }
        public int Flags { get; set; }
        public int MaleDisplayId { get; set; }
        public int FemaleDisplayId { get; set; }
        public uint HighResMaleDisplayId { get; set; }
        public int HighResFemaleDisplayId { get; set; }
        public int CreateScreenFileDataId { get; set; }
        public int SelectScreenFileDataId { get; set; }
        [HotfixArray(3)]
        public float[] MaleCustomizeOffset { get; set; }
        [HotfixArray(3)]
        public float[] FemaleCustomizeOffset { get; set; }
        public int LowResScreenFileDataId { get; set; }
        [HotfixArray(3)]
        public int[] AlteredFormStartVisualKitId { get; set; }
        [HotfixArray(3)]
        public int[] AlteredFormFinishVisualKitId { get; set; }
        public int HeritageArmorAchievementId { get; set; }
        public int StartingLevel { get; set; }
        public int UiDisplayOrder { get; set; }
        public int FemaleSkeletonFileDataId { get; set; }
        public int MaleSkeletonFileDataId { get; set; }
        public int BaseRaceId { get; set; }
        public ushort FactionId { get; set; }
        public ushort CinematicSequenceId { get; set; }
        public ushort ResSicknessSpellId { get; set; }
        public ushort SplashSoundId { get; set; }
        public byte BaseLanguage { get; set; }
        public byte CreatureType { get; set; }
        public byte Alliance { get; set; }
        public byte RaceRelated { get; set; }
        public byte UnalteredVisualRaceId { get; set; }
        public byte CharComponentTextureLayoutId { get; set; }
        public byte CharComponentTexLayoutHiResId { get; set; }
        public byte DefaultClassId { get; set; }
        public byte NeutralRaceId { get; set; }
        public byte MaleModelFallbackRaceId { get; set; }
        public byte MaleModelFallbackSex { get; set; }
        public byte FemaleModelFallbackRaceId { get; set; }
        public byte FemaleModelFallbackSex { get; set; }
        public byte MaleTextureFallbackRaceId { get; set; }
        public byte MaleTextureFallbackSex { get; set; }
        public byte FemaleTextureFallbackRaceId { get; set; }
        public byte FemaleTextureFallbackSex { get; set; }
    }
}