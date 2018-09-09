using System.Reflection.Emit;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V7_0_3_22248.Parsers
{
    public static class GarrisonHandler
    {
        public static void ReadGarrisonMission(Packet packet, params object[] indexes)
        {
            packet.ReadUInt64("DbID", indexes);
            packet.ReadInt32("MissionRecID", indexes);
            packet.ReadTime("OfferTime", indexes);
            packet.ReadInt32("OfferDuration", indexes);
            packet.ReadTime("StartTime", indexes);
            packet.ReadInt32("TravelDuration", indexes);
            packet.ReadInt32("MissionDuration", indexes);
            packet.ReadUInt32E<GarrisonMissionState>("MissionState", indexes);
            packet.ReadInt32("SuccessChance", indexes);
            packet.ReadUInt32E<GarrisonMissionFlag>("Flags", indexes);
        }

        public static void ReadGarrisonMissionOvermaxRewards(Packet packet, params object[] indexes)
        {
            var missionRewardCount = packet.ReadInt32("MissionRewardCount", indexes);
            for (int i = 0; i < missionRewardCount; i++)
                ReadGarrisonMissionReward(packet, indexes, i);
        }

        public static void ReadGarrisonBuildingInfo(Packet packet, params object[] indexes)
        {
            packet.ReadInt32("GarrPlotInstanceID", indexes);
            packet.ReadInt32("GarrBuildingID", indexes);
            packet.ReadTime("TimeBuilt", indexes);
            packet.ReadInt32("CurrentGarSpecID", indexes);
            packet.ReadInt32("TimeSpecCooldown", indexes);

            packet.ResetBitReader();

            packet.ReadBit("Active", indexes);
        }

        public static void ReadGarrisonFollower(Packet packet, params object[] indexes)
        {
            packet.ReadUInt64("DbID", indexes);
            packet.ReadInt32("GarrFollowerID", indexes);
            packet.ReadInt32E<GarrisonFollowerQuality>("Quality", indexes);
            packet.ReadInt32("FollowerLevel", indexes);
            packet.ReadInt32("ItemLevelWeapon", indexes);
            packet.ReadInt32("ItemLevelArmor", indexes);
            packet.ReadInt32("Xp", indexes);
            packet.ReadInt32("Durability", indexes);
            packet.ReadInt32("CurrentBuildingID", indexes);
            packet.ReadInt32("CurrentMissionID", indexes);
            var abilityCount = packet.ReadUInt32("AbilityCount", indexes);
            packet.ReadInt32("ZoneSupportSpellID", indexes);
            packet.ReadInt32E<GarrisonFollowerStatus>("FollowerStatus", indexes);

            for (int i = 0; i < abilityCount; i++)
                packet.ReadInt32("AbilityID", indexes, i);

            packet.ResetBitReader();

            var len = packet.ReadBits(7);
            packet.ReadWoWString("CustomName", len, indexes);
        }

        public static void ReadGarrisonTalents(Packet packet, params object[] indexes)
        {
            packet.ReadInt32("GarrTalentID", indexes);
            packet.ReadInt32("ResearchStartTime", indexes);
            packet.ReadInt32("Flags", indexes);
        }

        public static void ReadFollowerSoftCapInfo(Packet packet, params object[] indexes)
        {
            packet.ReadInt32("GarrFollowerTypeID", indexes);
            packet.ReadUInt32("Count", indexes);
        }

        public static void ReadGarrisonShipment(Packet packet, params object[] indexes)
        {
            packet.ReadInt32("ShipmentRecId", indexes);
            packet.ReadUInt64("ShipmentId", indexes);
            packet.ReadUInt64("AssignedFollowerDBID", indexes);
            packet.ReadTime("CreationTime", indexes);
            packet.ReadInt32("ShipmentDuration", indexes);
            packet.ReadInt32("BuildingType", indexes);
        }

        public static void ReadGarrisonMissionReward(Packet packet, params object[] indexes)
        {
            packet.ReadInt32<ItemId>("ItemId", indexes);
            packet.ReadUInt32("Quantity", indexes);
            packet.ReadInt32<CurrencyId>("CurrencyId", indexes);
            packet.ReadUInt32("CurrencyQuantity", indexes);
            packet.ReadUInt32("FollowerXp", indexes);
            packet.ReadUInt32("BonusAbilityId", indexes);
            packet.ReadInt32("ItemFileDataID", indexes);
        }

        public static void ReadGarrisonFollowerCategoryInfo(Packet packet, params object[] indexes)
        {
            packet.ReadInt32("GarrClassSpecId", indexes);
            packet.ReadInt32("GarrClassSpecPlayerCondId", indexes);
        }

        [Parser(Opcode.SMSG_DISPLAY_TOAST)]
        public static void HandleDisplayToast(Packet packet)
        {
            packet.ReadUInt64("Quantity");

            packet.ReadByte("DisplayToastMethod");
            packet.ReadUInt32("QuestID");

            packet.ResetBitReader();

            packet.ReadBit("Mailed");

            var type = packet.ReadBits("Type", 2);
            if (type == 0)
            {
                packet.ReadBit("BonusRoll");
                V6_0_2_19033.Parsers.ItemHandler.ReadItemInstance(packet);
                packet.ReadInt32("SpecializationID");
                packet.ReadInt32("ItemQuantity?");
            }

            if (type == 1)
                packet.ReadInt32("CurrencyID");
        }

        [Parser(Opcode.SMSG_GET_GARRISON_INFO_RESULT)]
        public static void HandleGetGarrisonInfoResult(Packet packet)
        {
            packet.ReadInt32("FactionIndex");
            var garrisonCount = packet.ReadUInt32("GarrisonCount");

            if (ClientVersion.AddedInVersion(ClientVersionBuild.V7_2_5_24330))
            {
                var followerSoftcapCount = packet.ReadUInt32("FollowerSoftCapCount");
                for (var i = 0u; i < followerSoftcapCount; ++i)
                    ReadFollowerSoftCapInfo(packet, i);
            }

            for (int i = 0; i < garrisonCount; i++)
            {
                packet.ReadInt32E<GarrisonType>("GarrTypeID", i);
                packet.ReadInt32E<GarrisonSite>("GarrSiteID", i);
                packet.ReadInt32E<GarrisonSiteLevel>("GarrSiteLevelID", i);

                var garrisonBuildingInfoCount = packet.ReadUInt32("GarrisonBuildingInfoCount", i);
                var garrisonPlotInfoCount = packet.ReadUInt32("GarrisonPlotInfoCount", i);
                var garrisonFollowerCount = packet.ReadUInt32("GarrisonFollowerCount", i);
                var garrisonMissionCount = packet.ReadUInt32("GarrisonMissionCount", i);
                var garrisonMissionRewardsCount = packet.ReadUInt32("GarrisonMissionRewardsCount", i);
                var garrisonMissionOvermaxRewardsCount = packet.ReadUInt32("GarrisonMissionOvermaxRewardsCount", i);
                var areaBonusCount = packet.ReadUInt32("GarrisonMissionAreaBonusCount", i);
                var talentsCount = packet.ReadUInt32("Talents", i);
                var canStartMissionCount = packet.ReadUInt32("CanStartMission", i);
                var archivedMissionsCount = packet.ReadUInt32("ArchivedMissionsCount", i);

                packet.ReadInt32("NumFollowerActivationsRemaining", i);
                packet.ReadUInt32("NumMissionsStartedToday", i);
                if (ClientVersion.AddedInVersion(ClientVersionBuild.V7_2_0_23826) && ClientVersion.RemovedInVersion(ClientVersionBuild.V7_2_5_24330))
                    packet.ReadInt32("FollowerSoftCap", i);

                if (ClientVersion.RemovedInVersion(ClientVersionBuild.V7_2_0_23826))
                    for (int j = 0; j < garrisonBuildingInfoCount; j++)
                        ReadGarrisonBuildingInfo(packet, "BuildingInfo", i, j);

                for (int j = 0; j < garrisonPlotInfoCount; j++)
                    V6_0_2_19033.Parsers.GarrisonHandler.ReadGarrisonPlotInfo(packet, "PlotInfo", i, j);

                if (ClientVersion.RemovedInVersion(ClientVersionBuild.V7_2_0_23826))
                    for (int j = 0; j < garrisonFollowerCount; j++)
                        ReadGarrisonFollower(packet, "Follower", i, j);

                for (int j = 0; j < garrisonMissionCount; j++)
                    ReadGarrisonMission(packet, "Mission", i, j);

                for (int j = 0; j < garrisonMissionRewardsCount; j++)
                    ReadGarrisonMissionOvermaxRewards(packet, "MissionRewards", i, j);

                for (int j = 0; j < garrisonMissionOvermaxRewardsCount; j++)
                    ReadGarrisonMissionOvermaxRewards(packet, "MissionOvermaxRewards", i, j);

                for (int j = 0; j < areaBonusCount; j++)
                    V6_0_2_19033.Parsers.GarrisonHandler.ReadGarrisonMissionAreaBonus(packet, "MissionAreaBonus", i, j);

                for (int j = 0; j < talentsCount; j++)
                    ReadGarrisonTalents(packet, "Talents", i, j);

                for (int j = 0; j < archivedMissionsCount; j++)
                    packet.ReadInt32("ArchivedMissions", i, j);

                if (ClientVersion.AddedInVersion(ClientVersionBuild.V7_2_0_23826))
                    for (int j = 0; j < garrisonBuildingInfoCount; j++)
                        ReadGarrisonBuildingInfo(packet, "BuildingInfo", i, j);

                packet.ResetBitReader();

                for (int j = 0; j < canStartMissionCount; j++)
                    packet.ReadBit("CanStartMission", i, j);

                packet.ResetBitReader();

                if (ClientVersion.AddedInVersion(ClientVersionBuild.V7_2_0_23826))
                    for (int j = 0; j < garrisonFollowerCount; j++)
                        ReadGarrisonFollower(packet, "Follower", i, j);
            }
        }

        [Parser(Opcode.SMSG_GARRISON_REQUEST_BLUEPRINT_AND_SPECIALIZATION_DATA_RESULT)]
        public static void HandleGarrisonRequestBlueprintAndSpecializationDataResult(Packet packet)
        {
            packet.ReadInt32E<GarrisonType>("GarrTypeID");
            var int8 = packet.ReadUInt32("SpecializationsKnownCount");
            var int4 = packet.ReadUInt32("BlueprintsKnownCount");

            for (var i = 0; i < int8; i++)
                packet.ReadInt32("SpecializationsKnown", i);

            for (var i = 0; i < int4; i++)
                packet.ReadInt32("BlueprintsKnown", i);
        }

        [Parser(Opcode.SMSG_GARRISON_ADD_FOLLOWER_RESULT)]
        public static void HandleGarrisonAddFollowerResult(Packet packet)
        {
            packet.ReadInt32E<GarrisonType>("GarrTypeID");
            packet.ReadInt32E<GarrisonResult>("Result");
            ReadGarrisonFollower(packet);
        }

        [Parser(Opcode.SMSG_GARRISON_LEARN_BLUEPRINT_RESULT)]
        public static void HandleGarrisonLearnBlueprintResult(Packet packet)
        {
            packet.ReadInt32E<GarrisonType>("GarrTypeID");
            packet.ReadInt32E<GarrisonResult>("Result");
            packet.ReadInt32("BuildingID");
        }

        [Parser(Opcode.SMSG_GARRISON_PLACE_BUILDING_RESULT)]
        public static void HandleGarrisonPlaceBuildingResult(Packet packet)
        {
            packet.ReadInt32E<GarrisonType>("GarrTypeID");
            packet.ReadInt32E<GarrisonResult>("Result");
            ReadGarrisonBuildingInfo(packet, "BuildingInfo");

            packet.ResetBitReader();

            packet.ReadBit("PlayActivationCinematic");
        }

        [Parser(Opcode.SMSG_GARRISON_START_MISSION_RESULT)]
        public static void HandleGarrisonStartMissionResult(Packet packet)
        {
            packet.ReadInt32E<MissionResultType>("Result");
            packet.ReadUInt16("SessionMissionCount");
            ReadGarrisonMission(packet, "Mission");

            var followerCount = packet.ReadUInt32("FollowerCount");
            for (int i = 0; i < followerCount; i++)
                packet.ReadUInt64("FollowerDBIDs", i);
        }

        [Parser(Opcode.SMSG_GARRISON_FOLLOWER_CHANGED_XP)]
        public static void HandleGarrisonFollowerChangedXp(Packet packet)
        {
            packet.ReadInt32("XPEarned");
            packet.ReadInt32("XPSource");
            ReadGarrisonFollower(packet, "FollowerBefore");
            ReadGarrisonFollower(packet, "FollowerAfter");
        }

        [Parser(Opcode.CMSG_OPEN_MISSION_NPC)]
        public static void HandleGarrisonNpcGUID(Packet packet)
        {
            packet.ReadPackedGuid128("NpcGUID");
            packet.ReadInt32E<GarrisonFollowerType>("FollowerType"); // Indicates which type of missions
        }

        [Parser(Opcode.SMSG_GARRISON_OPEN_MISSION_NPC)]
        public static void HandleGarrisonOpenMissionNpc(Packet packet)
        {
            packet.ReadPackedGuid128("NpcGuid");
            packet.ReadInt32E<GarrisonFollowerType>("FollowerType"); // Indicates which type of missions
        }

        [Parser(Opcode.SMSG_GARRISON_LANDING_PAGE_SHIPMENT_INFO)]
        public static void HandleGarrisonLandingPageShipmentInfo(Packet packet)
        {
            packet.ReadUInt32("UnkUInt32");
            uint shipmentsCount = packet.ReadUInt32("ShipmentsCount");
            for (uint i = 0; i < shipmentsCount; i++)
                ReadGarrisonShipment(packet, "Shipment", i);
        }

        [Parser(Opcode.SMSG_GARRISON_MISSION_BONUS_ROLL_RESULT)]
        public static void HandleGarrisonMissionBonusRollResult(Packet packet)
        {
            ReadGarrisonMission(packet, "Mission");
            packet.ReadInt32("MissionRecID");
            packet.ReadInt32E<MissionResultType>("Result");
        }

        [Parser(Opcode.SMSG_GARRISON_COMPLETE_MISSION_RESULT)]
        public static void HandleGarrisonFinishMission(Packet packet)
        {
            packet.ReadInt32E<MissionResultType>("Result");
            ReadGarrisonMission(packet, "Mission");
            packet.ReadInt32("MissionRecId");

            if (ClientVersion.AddedInVersion(ClientVersionBuild.V7_2_0_24015)) // even earlier?
            {
                uint count = packet.ReadUInt32("MissionFollowerCount");
                for (uint i = 0; i < count; i++)
                {
                    packet.ReadUInt64("FollowerDBID", i);
                    packet.ReadUInt32("UnkUint32", i); // MissionCompleteState ?
                }
                packet.ReadBit("Succeeded");
            }
        }

        [Parser(Opcode.SMSG_GARRISON_MISSION_UPDATE_CAN_START)]
        public static void HandleGarrisonMissionUpdateCanStart(Packet packet)
        {
            uint missionsCount = packet.ReadUInt32("MissionsCount");
            uint canStartMissionCount = packet.ReadUInt32("CanStartMissionCount");

            for (uint i = 0; i < missionsCount; i++)
                packet.ReadInt32("MissionRecID", i);

            for (uint i = 0; i < canStartMissionCount; i++)
                packet.ReadBit("CanStartMission", i);
        }

        [Parser(Opcode.SMSG_GARRISON_FOLLOWER_CATEGORIES)]
        public static void HandleGarrisonFollowerCategories(Packet packet)
        {
            packet.ReadInt32E<GarrisonFollowerType>("FollowerTypeId");
            uint count = packet.ReadUInt32("CategoryInfoCount");
            for (uint i = 0; i < count; i++)
                ReadGarrisonFollowerCategoryInfo(packet, "FollowerCategoryInfo", i);
        }

        [Parser(Opcode.SMSG_GARRISON_ADD_MISSION_RESULT)]
        public static void HandleGarrisonAddMissionResult(Packet packet)
        {
            packet.ReadInt32E<GarrisonType>("GarrTypeId");
            packet.ReadInt32E<GarrisonResult>("Result");
            packet.ReadByte("UnkByte");

            ReadGarrisonMission(packet, "Mission");

            uint rewardCount1 = packet.ReadUInt32("RewardsCount");
            uint rewardCount2 = packet.ReadUInt32("OvermaxRewardsCount");

            for (int i = 0; i < rewardCount1; i++)
                ReadGarrisonMissionReward(packet, "MissionReward", i);

            for (int i = 0; i < rewardCount2; i++)
                ReadGarrisonMissionReward(packet, "MissionOvermaxReward", i);

            packet.ResetBitReader();
            packet.ReadBit("CanStart");
        }

        [Parser(Opcode.CMSG_ADVENTURE_JOURNAL_START_QUEST)]
        public static void HandleAdventurejournalStartQuest(Packet packet)
        {
            packet.ReadInt32<QuestId>("QuestID");
        }

        [Parser(Opcode.SMSG_GARRISON_CLEAR_ALL_FOLLOWERS_EXHAUSTION)]
        public static void HandleGarrisonAllFollowersExhaustion(Packet packet)
        {
            packet.ReadInt32E<GarrisonType>("GarrTypeID");
            packet.ReadInt32E<GarrisonResult>("Result");
        }
    }
}
