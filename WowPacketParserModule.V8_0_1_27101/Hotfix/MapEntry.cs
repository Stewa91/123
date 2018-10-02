using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Map, HasIndexInData = false)]
    public class MapEntry
    {
        public string Directory { get; set; }
        public string MapName { get; set; }
        public string MapDescription0 { get; set; }
        public string MapDescription1 { get; set; }
        public string PvpShortDescription { get; set; }
        public string PvpLongDescription { get; set; }
        [HotfixArray(2)]
        public float[] Corpse { get; set; }
        public byte MapType { get; set; }
        public byte InstanceType { get; set; }
        public byte ExpansionId { get; set; }
        public ushort AreaTableId { get; set; }
        public ushort LoadingScreenId { get; set; }
        public ushort TimeOfDayOverride { get; set; }
        public ushort ParentMapId { get; set; }
        public ushort CosmeticParentMapId { get; set; }
        public byte TimeOffset { get; set; }
        public float MinimapIconScale { get; set; }
        public ushort CorpseMapId { get; set; }
        public byte MaxPlayers { get; set; }
        public ushort WindSettingsId { get; set; }
        public int ZmpFileDataId { get; set; }
        [HotfixArray(2)]
        public uint[] Flags { get; set; }
    }
}
    