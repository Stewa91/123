using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SoundOverride, HasIndexInData = false)]
    public class SoundOverrideEntry
    {
        public ushort ZoneIntroMusicId { get; set; }
        public ushort ZoneMusicId { get; set; }
        public ushort SoundAmbienceId { get; set; }
        public byte SoundProviderPreferencesId { get; set; }
    }
}