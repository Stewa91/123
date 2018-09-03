using System;

namespace WowPacketParser.Enums
{
    public enum GarrisonFollowerType : int
    {
        None                          = 0,
        DraenorFollower               = 1,
        DraenorNaval                  = 2,
        ClassOrderHallFollower        = 4
    }

    public enum GarrisonType : int
    {
        None            = 0,
        DraenorGarrison = 2,
        OrderHall       = 3,
        BfA             = 9
    }

    public enum GarrisonResult : int
    {
        SUCCESS                                   = 0,
        NO_GARRISON                               = 1,
        GARRISON_EXISTS                           = 2,
        GARRISON_SAME_TYPE_EXISTS                 = 3,
        INVALID_GARRISON                          = 4,
        INVALID_GARRISON_LEVEL                    = 5,
        GARRISON_LEVEL_UNCHANGED                  = 6,
        NOT_IN_GARRISON                           = 7,
        NO_BUILDING                               = 8,
        BUILDING_EXISTS                           = 9,
        INVALID_PLOT_INSTANCEID                   = 10,
        INVALID_BUILDINGID                        = 11,
        INVALID_UPGRADE_LEVEL                     = 12,
        UPGRADE_LEVEL_EXCEEDS_GARRISON_LEVEL      = 13,
        PLOTS_NOT_FULL                            = 14,
        INVALID_SITE_ID                           = 15,
        INVALID_PLOT_BUILDING                     = 16,
        INVALID_FACTION                           = 17,
        INVALID_SPECIALIZATION                    = 18,
        SPECIALIZATION_EXISTS                     = 19,
        SPECIALIZATION_ON_COOLDOWN                = 20,
        BLUEPRINT_EXISTS                          = 21,
        REQUIRES_BLUEPRINT                        = 22,
        INVALID_DOODAD_SET_ID                     = 23,
        BUILDING_TYPE_EXISTS                      = 24,
        BUILDING_NOT_ACTIVE                       = 25,
        CONSTRUCTION_COMPLETE                     = 26,
        FOLLOWER_EXISTS                           = 27,
        INVALID_FOLLOWER                          = 28,
        FOLLOWER_ALREADY_ON_MISSION               = 29,
        FOLLOWER_IN_BUILDING                      = 30,
        FOLLOWER_INVALID_FOR_BUILDING             = 31,
        INVALID_FOLLOWER_LEVEL                    = 32,
        MISSION_EXISTS                            = 33,
        INVALID_MISSION                           = 34,
        INVALID_MISSION_TIME                      = 35,
        INVALID_MISSION_REWARD_INDEX              = 36,
        MISSION_NOT_OFFERED                       = 37,
        ALREADY_ON_MISSION                        = 38,
        MISSION_SIZE_INVALID                      = 39,
        FOLLOWER_SOFT_CAP_EXCEEDED                = 40,
        NOT_ON_MISSION                            = 41,
        ALREADY_COMPLETED_MISSION                 = 42,
        MISSION_NOT_COMPLETE                      = 43,
        MISSION_REWARDS_PENDING                   = 44,
        MISSION_EXPIRED                           = 45,
        NOT_ENOUGH_CURRENCY                       = 46,
        NOT_ENOUGH_GOLD                           = 47,
        BUILDING_MISSING                          = 48,
        NO_ARCHITECT                              = 49,
        ARCHITECT_NOT_AVAILABLE                   = 50,
        NO_MISSION_NPC                            = 51,
        MISSION_NPC_NOT_AVAILABLE                 = 52,
        INTERNAL_ERROR                            = 53,
        INVALID_STATIC_TABLE_VALUE                = 54,
        INVALID_ITEM_LEVEL                        = 55,
        INVALID_AVAILABLE_RECRUIT                 = 56,
        FOLLOWER_ALREADY_RECRUITED                = 57,
        RECRUITMENT_GENERATION_IN_PROGRESS        = 58,
        RECRUITMENT_ON_COOLDOWN                   = 59,
        RECRUIT_BLOCKED_BY_GENERATION             = 60,
        RECRUITMENT_NPC_NOT_AVAILABLE             = 61,
        INVALID_FOLLOWER_QUALITY                  = 62,
        PROXY_NOT_OK                              = 63,
        RECALL_PORTAL_USED_LESS_THAN_24_HOURS_AGO = 64,
        ON_REMOVE_BUILDING_SPELL_FAILED           = 65,
        OPERATION_NOT_SUPPORTED                   = 66,
        FOLLOWER_FATIGUED                         = 67,
        UPGRADE_CONDITION_FAILED                  = 68,
        FOLLOWER_INACTIVE                         = 69,
        FOLLOWER_ACTIVE                           = 70,
        FOLLOWER_ACTIVATION_UNAVAILABLE           = 71,
        FOLLOWER_TYPE_MISMATCH                    = 72,
        INVALID_GARRISON_TYPE                     = 73,
        MISSION_START_CONDITION_FAILED            = 74,
        INVALID_FOLLOWER_ABILITY                  = 75,
        INVALID_MISSION_BONUS_ABILITY             = 76,
        HIGHER_BUILDING_TYPE_EXISTS               = 77,
        AT_FOLLOWER_HARD_CAP                      = 78,
        FOLLOWER_CANNOT_GAIN_XP                   = 79,
        NO_OP                                     = 80,
        AT_CLASS_SPEC_CAP                         = 81,
        MISSION_REQUIRES_100_TO_START             = 82,
        MISSION_MISSING_REQUIRED_FOLLOWER         = 83,
        INVALID_TALENT                            = 84,
        ALREADY_RESEARCHING_TALENT                = 85,
        FAILED_CONDITION                          = 86,
        INVALID_TIER                              = 87,
        INVALID_CLASS                             = 88
    }

    public enum GarrisonMissionState : uint
    {
        Offered              = 0,
        InProgress           = 1,
        Completed            = 2,
        OvermaxRewardPending = 3,
        Reward1Claimed       = 4,
        Reward2Claimed       = 5,
        Reward3Claimed       = 6
    }

    public enum GarrisonSite
    {
        None              = 0,
        Lunarfall         = 2,
        Frostwall         = 71,
        AllianceClassHall = 161,
        HordeClassHall    = 163
    }

    public enum GarrisonSiteLevel
    {
        None = 0,

        LunarfallLevel1 = 5,
        LunarfallLevel2 = 444,
        LunarfallLevel3 = 6,

        AllianceClassHallLevel1 = 560,
        AllianceClassHallLevel2 = 579,
        AllianceClassHallLevel3 = 580,

        FrostwallLevel1 = 258,
        FrostwallLevel2 = 445,
        FrostwallLevel3 = 259,

        HordeClassHallLevel1 = 584,
        HordeClassHallLevel2 = 585,
        HordeClassHallLevel3 = 586
    }

    public enum MissionResultType
    {
        inProgress,
        completing,
        success,
        failure
    }

    [Flags]
    public enum GarrisonMissionFlag : uint
    {
        none           = 0x00,
        isRare         = 0x01,
        isElite        = 0x02,
        appliesFatigue = 0x04,
        alwaysFail     = 0x08,
        isZoneSupport  = 0x10
    }

    public enum GarrisonShipmentResult
    {
        SUCCESS,
        INVALID_SHIPMENT,
        SHIPMENT_NOT_READY,
        CONTAINER_FULL,
        SHIPMENTS_MAXED,
        NO_NPC,
        NPC_NOT_AVAILABLE,
        INTERNAL_ERROR,
        SHIPMENT_EMPTY,
        BAG_ERROR
    }

    public enum GarrisonFollowerQuality
    {
        NONE,
        COMMON,
        UNCOMMON,
        RARE,
        EPIC,
        LEGENDARY,
        TITLE
    }

    public enum GarrisonFollowerCategory
    {
        ActiveChampion,
        InactiveChampion,
        Troop,
    }

    public enum GarrisonFollowerStatus
    {
        available,
        onMission,
        inBuilding,
        fatigued,
        inactive
    }
}
