using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ScreenEffect, HasIndexInData = false)]
    public class ScreenEffectEntry
    {
        public string Name { get; set; }
        [HotfixArray(4)]
        public uint[] Param { get; set; }
        public byte Effect { get; set; }
        public uint FullScreenEffectId { get; set; }
        public ushort LightParamsId { get; set; }
        public ushort LightParamsFadeIn { get; set; }
        public ushort LightParamsFadeOut { get; set; }
        public int SoundAmbienceId { get; set; }
        public uint ZoneMusicId { get; set; }
        public ushort TimeOfDayOverride { get; set; }
        public byte EffectMask { get; set; }
        public byte LightFlags { get; set; }
    }
}