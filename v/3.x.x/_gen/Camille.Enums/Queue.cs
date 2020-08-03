
// This file is automatically generated.
// Do not directly edit.
// Generated on 2020-08-03T03:12:09.075Z

using System;
using System.ComponentModel.DataAnnotations;

namespace Camille.Enums
{
    /// <summary>
    /// Queues enum based on queues.json.
    /// </summary>
    public enum Queue
    {
        [Display(Name = "Custom games", Description = "Games on Custom games")]
        CUSTOM = 0,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 430")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Blind Pick games on Summoner's Rift")]
        SUMMONERS_RIFT_5V5_BLIND_PICK_DEPRECATED_2 = 2,

        [Obsolete("Deprecated in favor of queueId 420")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Ranked Solo games on Summoner's Rift")]
        SUMMONERS_RIFT_5V5_RANKED_SOLO_DEPRECATED_4 = 4,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Ranked Premade games on Summoner's Rift")]
        SUMMONERS_RIFT_5V5_RANKED_PREMADE = 6,

        [Obsolete("Deprecated in favor of queueId 32 and 33")]
        [Display(Name = "Summoner's Rift", Description = "Co-op vs AI games on Summoner's Rift")]
        SUMMONERS_RIFT_CO_OP_VS_AI = 7,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 460")]
        [Display(Name = "Twisted Treeline", Description = "3v3 Normal games on Twisted Treeline")]
        TWISTED_TREELINE_3V3_NORMAL = 8,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 470")]
        [Display(Name = "Twisted Treeline", Description = "3v3 Ranked Flex games on Twisted Treeline")]
        TWISTED_TREELINE_3V3_RANKED_FLEX_DEPRECATED_9 = 9,

        [Obsolete("Deprecated in favor of queueId 400")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Draft Pick games on Summoner's Rift")]
        SUMMONERS_RIFT_5V5_DRAFT_PICK_DEPRECATED_14 = 14,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Crystal Scar", Description = "5v5 Dominion Blind Pick games on Crystal Scar")]
        CRYSTAL_SCAR_5V5_DOMINION_BLIND_PICK = 16,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Crystal Scar", Description = "5v5 Dominion Draft Pick games on Crystal Scar")]
        CRYSTAL_SCAR_5V5_DOMINION_DRAFT_PICK = 17,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Crystal Scar", Description = "Dominion Co-op vs AI games on Crystal Scar")]
        CRYSTAL_SCAR_DOMINION_CO_OP_VS_AI = 25,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 830")]
        [Display(Name = "Summoner's Rift", Description = "Co-op vs AI Intro Bot games on Summoner's Rift")]
        SUMMONERS_RIFT_CO_OP_VS_AI_INTRO_BOT_DEPRECATED_31 = 31,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 840")]
        [Display(Name = "Summoner's Rift", Description = "Co-op vs AI Beginner Bot games on Summoner's Rift")]
        SUMMONERS_RIFT_CO_OP_VS_AI_BEGINNER_BOT_DEPRECATED_32 = 32,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 850")]
        [Display(Name = "Summoner's Rift", Description = "Co-op vs AI Intermediate Bot games on Summoner's Rift")]
        SUMMONERS_RIFT_CO_OP_VS_AI_INTERMEDIATE_BOT_DEPRECATED_33 = 33,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Twisted Treeline", Description = "3v3 Ranked Team games on Twisted Treeline")]
        TWISTED_TREELINE_3V3_RANKED_TEAM = 41,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Ranked Team games on Summoner's Rift")]
        SUMMONERS_RIFT_5V5_RANKED_TEAM = 42,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 800")]
        [Display(Name = "Twisted Treeline", Description = "Co-op vs AI games on Twisted Treeline")]
        TWISTED_TREELINE_CO_OP_VS_AI = 52,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Team Builder games on Summoner's Rift")]
        SUMMONERS_RIFT_5V5_TEAM_BUILDER = 61,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 450")]
        [Display(Name = "Howling Abyss", Description = "5v5 ARAM games on Howling Abyss")]
        HOWLING_ABYSS_5V5_ARAM_DEPRECATED_65 = 65,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Howling Abyss", Description = "ARAM Co-op vs AI games on Howling Abyss")]
        HOWLING_ABYSS_ARAM_CO_OP_VS_AI = 67,

        [Obsolete("Deprecated in patch 8.6 in favor of queueId 1020")]
        [Display(Name = "Summoner's Rift", Description = "One for All games on Summoner's Rift")]
        SUMMONERS_RIFT_ONE_FOR_ALL_DEPRECATED_70 = 70,

        [Display(Name = "Howling Abyss", Description = "1v1 Snowdown Showdown games on Howling Abyss")]
        HOWLING_ABYSS_1V1_SNOWDOWN_SHOWDOWN = 72,

        [Display(Name = "Howling Abyss", Description = "2v2 Snowdown Showdown games on Howling Abyss")]
        HOWLING_ABYSS_2V2_SNOWDOWN_SHOWDOWN = 73,

        [Display(Name = "Summoner's Rift", Description = "6v6 Hexakill games on Summoner's Rift")]
        SUMMONERS_RIFT_6V6_HEXAKILL = 75,

        [Display(Name = "Summoner's Rift", Description = "Ultra Rapid Fire games on Summoner's Rift")]
        SUMMONERS_RIFT_ULTRA_RAPID_FIRE = 76,

        [Display(Name = "Howling Abyss", Description = "One For All: Mirror Mode games on Howling Abyss")]
        HOWLING_ABYSS_ONE_FOR_ALL_MIRROR_MODE = 78,

        [Display(Name = "Summoner's Rift", Description = "Co-op vs AI Ultra Rapid Fire games on Summoner's Rift")]
        SUMMONERS_RIFT_CO_OP_VS_AI_ULTRA_RAPID_FIRE = 83,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 950")]
        [Display(Name = "Summoner's Rift", Description = "Doom Bots Rank 1 games on Summoner's Rift")]
        SUMMONERS_RIFT_DOOM_BOTS_RANK_1 = 91,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 950")]
        [Display(Name = "Summoner's Rift", Description = "Doom Bots Rank 2 games on Summoner's Rift")]
        SUMMONERS_RIFT_DOOM_BOTS_RANK_2 = 92,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 950")]
        [Display(Name = "Summoner's Rift", Description = "Doom Bots Rank 5 games on Summoner's Rift")]
        SUMMONERS_RIFT_DOOM_BOTS_RANK_5 = 93,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 910")]
        [Display(Name = "Crystal Scar", Description = "Ascension games on Crystal Scar")]
        CRYSTAL_SCAR_ASCENSION_DEPRECATED_96 = 96,

        [Display(Name = "Twisted Treeline", Description = "6v6 Hexakill games on Twisted Treeline")]
        TWISTED_TREELINE_6V6_HEXAKILL = 98,

        [Display(Name = "Butcher's Bridge", Description = "5v5 ARAM games on Butcher's Bridge")]
        BUTCHERS_BRIDGE_5V5_ARAM = 100,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 920")]
        [Display(Name = "Howling Abyss", Description = "Legend of the Poro King games on Howling Abyss")]
        HOWLING_ABYSS_LEGEND_OF_THE_PORO_KING_DEPRECATED_300 = 300,

        [Display(Name = "Summoner's Rift", Description = "Nemesis games on Summoner's Rift")]
        SUMMONERS_RIFT_NEMESIS = 310,

        [Display(Name = "Summoner's Rift", Description = "Black Market Brawlers games on Summoner's Rift")]
        SUMMONERS_RIFT_BLACK_MARKET_BRAWLERS = 313,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 940")]
        [Display(Name = "Summoner's Rift", Description = "Nexus Siege games on Summoner's Rift")]
        SUMMONERS_RIFT_NEXUS_SIEGE_DEPRECATED_315 = 315,

        [Display(Name = "Crystal Scar", Description = "Definitely Not Dominion games on Crystal Scar")]
        CRYSTAL_SCAR_DEFINITELY_NOT_DOMINION = 317,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 900")]
        [Display(Name = "Summoner's Rift", Description = "ARURF games on Summoner's Rift")]
        SUMMONERS_RIFT_ARURF = 318,

        [Display(Name = "Summoner's Rift", Description = "All Random games on Summoner's Rift")]
        SUMMONERS_RIFT_ALL_RANDOM = 325,

        [Display(Name = "Summoner's Rift", Description = "5v5 Draft Pick games on Summoner's Rift")]
        SUMMONERS_RIFT_5V5_DRAFT_PICK = 400,

        [Obsolete("Game mode deprecated in patch 6.22")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Ranked Dynamic games on Summoner's Rift")]
        SUMMONERS_RIFT_5V5_RANKED_DYNAMIC = 410,

        [Display(Name = "Summoner's Rift", Description = "5v5 Ranked Solo games on Summoner's Rift")]
        SUMMONERS_RIFT_5V5_RANKED_SOLO = 420,

        [Display(Name = "Summoner's Rift", Description = "5v5 Blind Pick games on Summoner's Rift")]
        SUMMONERS_RIFT_5V5_BLIND_PICK = 430,

        [Display(Name = "Summoner's Rift", Description = "5v5 Ranked Flex games on Summoner's Rift")]
        SUMMONERS_RIFT_5V5_RANKED_FLEX = 440,

        [Display(Name = "Howling Abyss", Description = "5v5 ARAM games on Howling Abyss")]
        HOWLING_ABYSS_5V5_ARAM = 450,

        [Obsolete("Deprecated in patch 9.23")]
        [Display(Name = "Twisted Treeline", Description = "3v3 Blind Pick games on Twisted Treeline")]
        TWISTED_TREELINE_3V3_BLIND_PICK = 460,

        [Obsolete("Deprecated in patch 9.23")]
        [Display(Name = "Twisted Treeline", Description = "3v3 Ranked Flex games on Twisted Treeline")]
        TWISTED_TREELINE_3V3_RANKED_FLEX_DEPRECATED_470 = 470,

        [Display(Name = "Summoner's Rift", Description = "Blood Hunt Assassin games on Summoner's Rift")]
        SUMMONERS_RIFT_BLOOD_HUNT_ASSASSIN = 600,

        [Display(Name = "Cosmic Ruins", Description = "Dark Star: Singularity games on Cosmic Ruins")]
        COSMIC_RUINS_DARK_STAR_SINGULARITY = 610,

        [Display(Name = "Summoner's Rift", Description = "Clash games on Summoner's Rift")]
        SUMMONERS_RIFT_CLASH = 700,

        [Obsolete("Deprecated in patch 9.23")]
        [Display(Name = "Twisted Treeline", Description = "Co-op vs. AI Intermediate Bot games on Twisted Treeline")]
        TWISTED_TREELINE_CO_OP_VS_AI_INTERMEDIATE_BOT = 800,

        [Obsolete("Deprecated in patch 9.23")]
        [Display(Name = "Twisted Treeline", Description = "Co-op vs. AI Intro Bot games on Twisted Treeline")]
        TWISTED_TREELINE_CO_OP_VS_AI_INTRO_BOT = 810,

        [Display(Name = "Twisted Treeline", Description = "Co-op vs. AI Beginner Bot games on Twisted Treeline")]
        TWISTED_TREELINE_CO_OP_VS_AI_BEGINNER_BOT = 820,

        [Display(Name = "Summoner's Rift", Description = "Co-op vs. AI Intro Bot games on Summoner's Rift")]
        SUMMONERS_RIFT_CO_OP_VS_AI_INTRO_BOT = 830,

        [Display(Name = "Summoner's Rift", Description = "Co-op vs. AI Beginner Bot games on Summoner's Rift")]
        SUMMONERS_RIFT_CO_OP_VS_AI_BEGINNER_BOT = 840,

        [Display(Name = "Summoner's Rift", Description = "Co-op vs. AI Intermediate Bot games on Summoner's Rift")]
        SUMMONERS_RIFT_CO_OP_VS_AI_INTERMEDIATE_BOT = 850,

        [Display(Name = "Summoner's Rift", Description = "URF games on Summoner's Rift")]
        SUMMONERS_RIFT_URF = 900,

        [Display(Name = "Crystal Scar", Description = "Ascension games on Crystal Scar")]
        CRYSTAL_SCAR_ASCENSION = 910,

        [Display(Name = "Howling Abyss", Description = "Legend of the Poro King games on Howling Abyss")]
        HOWLING_ABYSS_LEGEND_OF_THE_PORO_KING = 920,

        [Display(Name = "Summoner's Rift", Description = "Nexus Siege games on Summoner's Rift")]
        SUMMONERS_RIFT_NEXUS_SIEGE = 940,

        [Display(Name = "Summoner's Rift", Description = "Doom Bots Voting games on Summoner's Rift")]
        SUMMONERS_RIFT_DOOM_BOTS_VOTING = 950,

        [Display(Name = "Summoner's Rift", Description = "Doom Bots Standard games on Summoner's Rift")]
        SUMMONERS_RIFT_DOOM_BOTS_STANDARD = 960,

        [Display(Name = "Valoran City Park", Description = "Star Guardian Invasion: Normal games on Valoran City Park")]
        VALORAN_CITY_PARK_STAR_GUARDIAN_INVASION_NORMAL = 980,

        [Display(Name = "Valoran City Park", Description = "Star Guardian Invasion: Onslaught games on Valoran City Park")]
        VALORAN_CITY_PARK_STAR_GUARDIAN_INVASION_ONSLAUGHT = 990,

        [Display(Name = "Overcharge", Description = "PROJECT: Hunters games on Overcharge")]
        OVERCHARGE_PROJECT_HUNTERS = 1000,

        [Display(Name = "Summoner's Rift", Description = "Snow ARURF games on Summoner's Rift")]
        SUMMONERS_RIFT_SNOW_ARURF = 1010,

        [Display(Name = "Summoner's Rift", Description = "One for All games on Summoner's Rift")]
        SUMMONERS_RIFT_ONE_FOR_ALL = 1020,

        [Display(Name = "Crash Site", Description = "Odyssey Extraction: Intro games on Crash Site")]
        CRASH_SITE_ODYSSEY_EXTRACTION_INTRO = 1030,

        [Display(Name = "Crash Site", Description = "Odyssey Extraction: Cadet games on Crash Site")]
        CRASH_SITE_ODYSSEY_EXTRACTION_CADET = 1040,

        [Display(Name = "Crash Site", Description = "Odyssey Extraction: Crewmember games on Crash Site")]
        CRASH_SITE_ODYSSEY_EXTRACTION_CREWMEMBER = 1050,

        [Display(Name = "Crash Site", Description = "Odyssey Extraction: Captain games on Crash Site")]
        CRASH_SITE_ODYSSEY_EXTRACTION_CAPTAIN = 1060,

        [Display(Name = "Crash Site", Description = "Odyssey Extraction: Onslaught games on Crash Site")]
        CRASH_SITE_ODYSSEY_EXTRACTION_ONSLAUGHT = 1070,

        [Display(Name = "Convergence", Description = "Teamfight Tactics games on Convergence")]
        CONVERGENCE_TEAMFIGHT_TACTICS = 1090,

        [Display(Name = "Convergence", Description = "Ranked Teamfight Tactics games on Convergence")]
        CONVERGENCE_RANKED_TEAMFIGHT_TACTICS = 1100,

        [Display(Name = "Convergence", Description = "Teamfight Tactics Tutorial games on Convergence")]
        CONVERGENCE_TEAMFIGHT_TACTICS_TUTORIAL = 1110,

        [Display(Name = "Convergence", Description = "Teamfight Tactics 1v0 testing games on Convergence")]
        CONVERGENCE_TEAMFIGHT_TACTICS_1V0_TESTING = 1111,

        [Obsolete("Deprecated in patch 9.2 in favor of queueId 1300")]
        [Display(Name = "Nexus Blitz", Description = "Nexus Blitz games on Nexus Blitz")]
        NEXUS_BLITZ_NEXUS_BLITZ_DEPRECATED_1200 = 1200,

        [Display(Name = "Nexus Blitz", Description = "Nexus Blitz games on Nexus Blitz")]
        NEXUS_BLITZ_NEXUS_BLITZ = 1300,

        [Display(Name = "Summoner's Rift", Description = "Tutorial 1 games on Summoner's Rift")]
        SUMMONERS_RIFT_TUTORIAL_1 = 2000,

        [Display(Name = "Summoner's Rift", Description = "Tutorial 2 games on Summoner's Rift")]
        SUMMONERS_RIFT_TUTORIAL_2 = 2010,

        [Display(Name = "Summoner's Rift", Description = "Tutorial 3 games on Summoner's Rift")]
        SUMMONERS_RIFT_TUTORIAL_3 = 2020,

    }
}
