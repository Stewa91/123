using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiMap)]
    public class UiMapEntry
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int ParentUiMapId { get; set; }
        public int Flags { get; set; }
        public int System { get; set; }
        public uint Type { get; set; }
        public uint LevelRangeMin { get; set; }
        public uint LevelRangeMax { get; set; }
        public int BountySetId { get; set; }
        public uint BountyDisplayLocation { get; set; }
        public int VisibilityPlayerConditionId { get; set; }
        public sbyte HelpTextPosition { get; set; }
        public int BkgAtlasId { get; set; }
    }
}