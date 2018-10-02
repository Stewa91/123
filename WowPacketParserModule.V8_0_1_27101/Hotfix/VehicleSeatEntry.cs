using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.VehicleSeat, HasIndexInData = false)]
    public class VehicleSeatEntry
    {
        [HotfixArray(3)]
        public float[] AttachmentOffset { get; set; }
        [HotfixArray(3)]
        public float[] CameraOffset { get; set; }
        public uint Flags { get; set; }
        public uint FlagsB { get; set; }
        public uint FlagsC { get; set; }
        public byte AttachmentId { get; set; }
        public float EnterPreDelay { get; set; }
        public float EnterSpeed { get; set; }
        public float EnterGravity { get; set; }
        public float EnterMinDuration { get; set; }
        public float EnterMaxDuration { get; set; }
        public float EnterMinArcHeight { get; set; }
        public float EnterMaxArcHeight { get; set; }
        public int EnterAnimStart { get; set; }
        public int EnterAnimLoop { get; set; }
        public int RideAnimStart { get; set; }
        public int RideAnimLoop { get; set; }
        public int RideUpperAnimStart { get; set; }
        public int RideUpperAnimLoop { get; set; }
        public float ExitPreDelay { get; set; }
        public float ExitSpeed { get; set; }
        public float ExitGravity { get; set; }
        public float ExitMinDuration { get; set; }
        public float ExitMaxDuration { get; set; }
        public float ExitMinArcHeight { get; set; }
        public float ExitMaxArcHeight { get; set; }
        public int ExitAnimStart { get; set; }
        public int ExitAnimLoop { get; set; }
        public int ExitAnimEnd { get; set; }
        public ushort VehicleEnterAnim { get; set; }
        public byte VehicleEnterAnimBone { get; set; }
        public ushort VehicleExitAnim { get; set; }
        public byte VehicleExitAnimBone { get; set; }
        public ushort VehicleRideAnimLoop { get; set; }
        public byte VehicleRideAnimLoopBone { get; set; }
        public byte PassengerAttachmentId { get; set; }
        public float PassengerYaw { get; set; }
        public float PassengerPitch { get; set; }
        public float PassengerRoll { get; set; }
        public float VehicleEnterAnimDelay { get; set; }
        public float VehicleExitAnimDelay { get; set; }
        public byte VehicleAbilityDisplay { get; set; }
        public int EnterUISoundId { get; set; }
        public uint ExitUISoundId { get; set; }
        public int UiSkinFileDataId { get; set; }
        public float CameraEnteringDelay { get; set; }
        public float CameraEnteringDuration { get; set; }
        public float CameraExitingDelay { get; set; }
        public float CameraExitingDuration { get; set; }
        public float CameraPosChaseRate { get; set; }
        public float CameraFacingChaseRate { get; set; }
        public float CameraEnteringZoom { get; set; }
        public float CameraSeatZoomMin { get; set; }
        public float CameraSeatZoomMax { get; set; }
        public ushort EnterAnimKitId { get; set; }
        public ushort RideAnimKitId { get; set; }
        public ushort ExitAnimKitId { get; set; }
        public ushort VehicleEnterAnimKitId { get; set; }
        public ushort VehicleRideAnimKitId { get; set; }
        public ushort VehicleExitAnimKitId { get; set; }
        public ushort CameraModeId { get; set; }
    }
}