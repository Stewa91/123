using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.TerrainMaterial, HasIndexInData = false)]
    public class TerrainMaterialEntry
    {
        public byte Shader { get; set; }
        public int EnvMapDiffuseFileId { get; set; }
        public int EnvMapSpecularFileId { get; set; }
    }
}