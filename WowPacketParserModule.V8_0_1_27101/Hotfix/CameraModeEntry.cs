using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CameraMode, HasIndexInData = false)]
    public class CameraModeEntry
    {
        [HotfixArray(3)]
        public float[] PositionOffset { get; set; }
        [HotfixArray(3)]
        public float[] TargetOffset { get; set; }
        public byte Type { get; set; }
        public uint Flags { get; set; }
        public float PositionSmoothing { get; set; }
        public float RotationSmoothing { get; set; }
        public float FieldOfView { get; set; }
        public byte LockedPositionOffsetBase { get; set; }
        public byte LockedPositionOffsetDirection { get; set; }
        public byte LockedTargetOffsetBase { get; set; }
        public byte LockedTargetOffsetDirection { get; set; }
    }
}