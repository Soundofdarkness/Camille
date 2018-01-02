﻿// This file is automatically generated.
// Do not directly edit.
// http://www.mingweisamuel.com/riotapi-schema/tool/
// Version 8d39db9a064557788d3d967fab2237638af4ee43

using System.Collections.Generic;

#region data objects

// champion-mastery-v3
namespace MingweiSamuel.Camille.ChampionMastery
{
    /// This object contains single Champion Mastery information for player and champion combination.
    public struct ChampionMastery
    {
        public bool ChestGranted;
        public int ChampionLevel;
        public int ChampionPoints;
        public long ChampionId;
        public long PlayerId;
        public long ChampionPointsUntilNextLevel;
        public long ChampionPointsSinceLastLevel;
        public long LastPlayTime;
    }
}

// champion-v3
namespace MingweiSamuel.Camille.Champion
{
    /// This object contains a collection of champion information.
    public struct ChampionListDto
    {
        public ChampionDto[] Champions;
    }
}

// champion-v3
namespace MingweiSamuel.Camille.Champion
{
    /// This object contains champion information.
    public struct ChampionDto
    {
        public bool RankedPlayEnabled;
        public bool BotEnabled;
        public bool BotMmEnabled;
        public bool Active;
        public bool FreeToPlay;
        public long Id;
    }
}

// league-v3
namespace MingweiSamuel.Camille.League
{
    public struct LeagueList
    {
        public string LeagueId;
        public string Tier;
        public LeaguePosition[] Entries;
        public string Queue;
        public string Name;
    }
}

// league-v3
namespace MingweiSamuel.Camille.League
{
    public struct MiniSeries
    {
        public int Wins;
        public int Losses;
        public int Target;
        public string Progress;
    }
}

// league-v3
namespace MingweiSamuel.Camille.League
{
    public struct LeaguePosition
    {
        public string Rank;
        public string QueueType;
        public bool HotStreak;
        public MiniSeries MiniSeries;
        public int Wins;
        public bool Veteran;
        public int Losses;
        public bool FreshBlood;
        public string LeagueId;
        public string PlayerOrTeamName;
        public bool Inactive;
        public string PlayerOrTeamId;
        public string LeagueName;
        public string Tier;
        public int LeaguePoints;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains champion list data.
    public struct ChampionListDto
    {
        public IDictionary<string, string> Keys;
        public IDictionary<string, ChampionDto> Data;
        public string Version;
        public string Type;
        public string Format;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains champion data.
    public struct ChampionDto
    {
        public InfoDto Info;
        public string[] Enemytips;
        public StatsDto Stats;
        public string Name;
        public string Title;
        public ImageDto Image;
        public string[] Tags;
        public string Partype;
        public SkinDto[] Skins;
        public PassiveDto Passive;
        public RecommendedDto[] Recommended;
        public string[] Allytips;
        public string Key;
        public string Lore;
        public int Id;
        public string Blurb;
        public ChampionSpellDto[] Spells;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains champion information.
    public struct InfoDto
    {
        public int Difficulty;
        public int Attack;
        public int Defense;
        public int Magic;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains champion stats data.
    public struct StatsDto
    {
        public double Armorperlevel;
        public double Hpperlevel;
        public double Attackdamage;
        public double Mpperlevel;
        public double Attackspeedoffset;
        public double Armor;
        public double Hp;
        public double Hpregenperlevel;
        public double Spellblock;
        public double Attackrange;
        public double Movespeed;
        public double Attackdamageperlevel;
        public double Mpregenperlevel;
        public double Mp;
        public double Spellblockperlevel;
        public double Crit;
        public double Mpregen;
        public double Attackspeedperlevel;
        public double Hpregen;
        public double Critperlevel;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains image data.
    public struct ImageDto
    {
        public string Full;
        public string Group;
        public string Sprite;
        public int H;
        public int W;
        public int Y;
        public int X;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains champion skin data.
    public struct SkinDto
    {
        public int Num;
        public string Name;
        public int Id;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains champion passive data.
    public struct PassiveDto
    {
        public ImageDto Image;
        public string SanitizedDescription;
        public string Name;
        public string Description;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains champion recommended data.
    public struct RecommendedDto
    {
        public string Map;
        public BlockDto[] Blocks;
        public string Champion;
        public string Title;
        public bool Priority;
        public string Mode;
        public string Type;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains champion recommended block data.
    public struct BlockDto
    {
        public BlockItemDto[] Items;
        public bool RecMath;
        public string Type;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains champion recommended block item data.
    public struct BlockItemDto
    {
        public int Count;
        public int Id;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains champion spell data.
    public struct ChampionSpellDto
    {
        public string CooldownBurn;
        public string Resource;
        public LevelTipDto Leveltip;
        public SpellVarsDto[] Vars;
        public string CostType;
        public ImageDto Image;
        public string SanitizedDescription;
        public string SanitizedTooltip;
        public double[][] Effect;
        public string Tooltip;
        public int Maxrank;
        public string CostBurn;
        public string RangeBurn;
        public int[] Range;
        public double[] Cooldown;
        public int[] Cost;
        public string Key;
        public string Description;
        public string[] EffectBurn;
        public ImageDto[] Altimages;
        public string Name;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains champion level tip data.
    public struct LevelTipDto
    {
        public string[] Effect;
        public string[] Label;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains spell vars data.
    public struct SpellVarsDto
    {
        public string RanksWith;
        public string Dyn;
        public string Link;
        public double[] Coeff;
        public string Key;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains item list data.
    public struct ItemListDto
    {
        public IDictionary<string, ItemDto> Data;
        public string Version;
        public ItemTreeDto[] Tree;
        public GroupDto[] Groups;
        public string Type;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains item tree data.
    public struct ItemTreeDto
    {
        public string Header;
        public string[] Tags;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains item data.
    public struct ItemDto
    {
        public GoldDto Gold;
        public string Plaintext;
        public bool HideFromAll;
        public bool InStore;
        public string[] Into;
        public int Id;
        public InventoryDataStatsDto Stats;
        public string Colloq;
        public IDictionary<string, bool> Maps;
        public int SpecialRecipe;
        public ImageDto Image;
        public string Description;
        public string[] Tags;
        public IDictionary<string, string> Effect;
        public string RequiredChampion;
        public string[] From;
        public string Group;
        public bool ConsumeOnFull;
        public string Name;
        public bool Consumed;
        public string SanitizedDescription;
        public int Depth;
        public int Stacks;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains item gold data.
    public struct GoldDto
    {
        public int Sell;
        public int Total;
        public int Base;
        public bool Purchasable;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains stats for inventory (e.g., runes and items).
    public struct InventoryDataStatsDto
    {
        public double PercentCritDamageMod;
        public double PercentSpellBlockMod;
        public double PercentHPRegenMod;
        public double PercentMovementSpeedMod;
        public double FlatSpellBlockMod;
        public double FlatCritDamageMod;
        public double FlatEnergyPoolMod;
        public double PercentLifeStealMod;
        public double FlatMPPoolMod;
        public double FlatMovementSpeedMod;
        public double PercentAttackSpeedMod;
        public double FlatBlockMod;
        public double PercentBlockMod;
        public double FlatEnergyRegenMod;
        public double PercentSpellVampMod;
        public double FlatMPRegenMod;
        public double PercentDodgeMod;
        public double FlatAttackSpeedMod;
        public double FlatArmorMod;
        public double FlatHPRegenMod;
        public double PercentMagicDamageMod;
        public double PercentMPPoolMod;
        public double FlatMagicDamageMod;
        public double PercentMPRegenMod;
        public double PercentPhysicalDamageMod;
        public double FlatPhysicalDamageMod;
        public double PercentHPPoolMod;
        public double PercentArmorMod;
        public double PercentCritChanceMod;
        public double PercentEXPBonus;
        public double FlatHPPoolMod;
        public double FlatCritChanceMod;
        public double FlatEXPBonus;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains item group data.
    public struct GroupDto
    {
        public string MaxGroupOwnable;
        public string Key;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains language strings data.
    public struct LanguageStringsDto
    {
        public IDictionary<string, string> Data;
        public string Version;
        public string Type;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains map data.
    public struct MapDataDto
    {
        public IDictionary<string, MapDetailsDto> Data;
        public string Version;
        public string Type;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains map details data.
    public struct MapDetailsDto
    {
        public string MapName;
        public ImageDto Image;
        public long MapId;
        public long[] UnpurchasableItemList;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains mastery list data.
    public struct MasteryListDto
    {
        public IDictionary<string, MasteryDto> Data;
        public string Version;
        public MasteryTreeDto Tree;
        public string Type;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains mastery tree data.
    public struct MasteryTreeDto
    {
        public MasteryTreeListDto[] Resolve;
        public MasteryTreeListDto[] Ferocity;
        public MasteryTreeListDto[] Cunning;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains mastery tree list data.
    public struct MasteryTreeListDto
    {
        public MasteryTreeItemDto[] MasteryTreeItems;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains mastery tree item data.
    public struct MasteryTreeItemDto
    {
        public int MasteryId;
        public string Prereq;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains mastery data.
    public struct MasteryDto
    {
        public string Prereq;
        public string MasteryTree;
        public string Name;
        public int Ranks;
        public ImageDto Image;
        public string[] SanitizedDescription;
        public int Id;
        public string[] Description;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains profile icon data.
    public struct ProfileIconDataDto
    {
        public IDictionary<string, ProfileIconDetailsDto> Data;
        public string Version;
        public string Type;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains profile icon details data.
    public struct ProfileIconDetailsDto
    {
        public ImageDto Image;
        public long Id;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains realm data.
    public struct RealmDto
    {
        public string Lg;
        public string Dd;
        public string L;
        public IDictionary<string, string> N;
        public int Profileiconmax;
        public string Store;
        public string V;
        public string Cdn;
        public string Css;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains rune list data.
    public struct RuneListDto
    {
        public IDictionary<string, RuneDto> Data;
        public string Version;
        public string Type;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains rune data.
    public struct RuneDto
    {
        public RuneStatsDto Stats;
        public string Name;
        public string[] Tags;
        public ImageDto Image;
        public string SanitizedDescription;
        public MetaDataDto Rune;
        public int Id;
        public string Description;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains stats for runes.
    public struct RuneStatsDto
    {
        public double PercentTimeDeadModPerLevel;
        public double PercentArmorPenetrationModPerLevel;
        public double PercentCritDamageMod;
        public double PercentSpellBlockMod;
        public double PercentHPRegenMod;
        public double PercentMovementSpeedMod;
        public double FlatSpellBlockMod;
        public double FlatEnergyRegenModPerLevel;
        public double FlatEnergyPoolMod;
        public double FlatMagicPenetrationModPerLevel;
        public double PercentLifeStealMod;
        public double FlatMPPoolMod;
        public double PercentCooldownMod;
        public double PercentMagicPenetrationMod;
        public double FlatArmorPenetrationModPerLevel;
        public double FlatMovementSpeedMod;
        public double FlatTimeDeadModPerLevel;
        public double FlatArmorModPerLevel;
        public double PercentAttackSpeedMod;
        public double FlatDodgeModPerLevel;
        public double PercentMagicDamageMod;
        public double PercentBlockMod;
        public double FlatDodgeMod;
        public double FlatEnergyRegenMod;
        public double FlatHPModPerLevel;
        public double PercentAttackSpeedModPerLevel;
        public double PercentSpellVampMod;
        public double FlatMPRegenMod;
        public double PercentHPPoolMod;
        public double PercentDodgeMod;
        public double FlatAttackSpeedMod;
        public double FlatArmorMod;
        public double FlatMagicDamageModPerLevel;
        public double FlatHPRegenMod;
        public double PercentPhysicalDamageMod;
        public double FlatCritChanceModPerLevel;
        public double FlatSpellBlockModPerLevel;
        public double PercentTimeDeadMod;
        public double FlatBlockMod;
        public double PercentMPPoolMod;
        public double FlatMagicDamageMod;
        public double PercentMPRegenMod;
        public double PercentMovementSpeedModPerLevel;
        public double PercentCooldownModPerLevel;
        public double FlatMPModPerLevel;
        public double FlatEnergyModPerLevel;
        public double FlatPhysicalDamageMod;
        public double FlatHPRegenModPerLevel;
        public double FlatCritDamageMod;
        public double PercentArmorMod;
        public double FlatMagicPenetrationMod;
        public double PercentCritChanceMod;
        public double FlatPhysicalDamageModPerLevel;
        public double PercentArmorPenetrationMod;
        public double PercentEXPBonus;
        public double FlatMPRegenModPerLevel;
        public double PercentMagicPenetrationModPerLevel;
        public double FlatTimeDeadMod;
        public double FlatMovementSpeedModPerLevel;
        public double FlatGoldPer10Mod;
        public double FlatArmorPenetrationMod;
        public double FlatCritDamageModPerLevel;
        public double FlatHPPoolMod;
        public double FlatCritChanceMod;
        public double FlatEXPBonus;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains meta data.
    public struct MetaDataDto
    {
        public string Tier;
        public string Type;
        public bool IsRune;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains summoner spell list data.
    public struct SummonerSpellListDto
    {
        public IDictionary<string, SummonerSpellDto> Data;
        public string Version;
        public string Type;
    }
}

// lol-static-data-v3
namespace MingweiSamuel.Camille.LolStaticData
{
    /// This object contains summoner spell data.
    public struct SummonerSpellDto
    {
        public SpellVarsDto[] Vars;
        public ImageDto Image;
        public string CostBurn;
        public double[] Cooldown;
        public string[] EffectBurn;
        public int Id;
        public string CooldownBurn;
        public string Tooltip;
        public int Maxrank;
        public string RangeBurn;
        public string Description;
        public double[][] Effect;
        public string Key;
        public LevelTipDto Leveltip;
        public string[] Modes;
        public string Resource;
        public string Name;
        public string CostType;
        public string SanitizedDescription;
        public string SanitizedTooltip;
        public int[] Range;
        public int[] Cost;
        public int SummonerLevel;
    }
}

// lol-status-v3
namespace MingweiSamuel.Camille.LolStatus
{
    public struct ShardStatus
    {
        public string Name;
        public string RegionTag;
        public string Hostname;
        public Service[] Services;
        public string Slug;
        public string[] Locales;
    }
}

// lol-status-v3
namespace MingweiSamuel.Camille.LolStatus
{
    public struct Service
    {
        public string Status;
        public Incident[] Incidents;
        public string Name;
        public string Slug;
    }
}

// lol-status-v3
namespace MingweiSamuel.Camille.LolStatus
{
    public struct Incident
    {
        public bool Active;
        public string CreatedAt;
        public long Id;
        public Message[] Updates;
    }
}

// lol-status-v3
namespace MingweiSamuel.Camille.LolStatus
{
    public struct Message
    {
        public string Severity;
        public string Author;
        public string CreatedAt;
        public Translation[] Translations;
        public string UpdatedAt;
        public string Content;
        public string Id;
    }
}

// lol-status-v3
namespace MingweiSamuel.Camille.LolStatus
{
    public struct Translation
    {
        public string Locale;
        public string Content;
        public string UpdatedAt;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct MatchDto
    {
        public int SeasonId;
        public int QueueId;
        public long GameId;
        public ParticipantIdentityDto[] ParticipantIdentities;
        public string GameVersion;
        public string PlatformId;
        public string GameMode;
        public int MapId;
        public string GameType;
        public TeamStatsDto[] Teams;
        public ParticipantDto[] Participants;
        public long GameDuration;
        public long GameCreation;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct ParticipantIdentityDto
    {
        public PlayerDto Player;
        public int ParticipantId;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct PlayerDto
    {
        public string CurrentPlatformId;
        public string SummonerName;
        public string MatchHistoryUri;
        public string PlatformId;
        public long CurrentAccountId;
        public int ProfileIcon;
        public long SummonerId;
        public long AccountId;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct TeamStatsDto
    {
        public bool FirstDragon;
        public bool FirstInhibitor;
        public TeamBansDto[] Bans;
        public int BaronKills;
        public bool FirstRiftHerald;
        public bool FirstBaron;
        public int RiftHeraldKills;
        public bool FirstBlood;
        public int TeamId;
        public bool FirstTower;
        public int VilemawKills;
        public int InhibitorKills;
        public int TowerKills;
        public int DominionVictoryScore;
        public string Win;
        public int DragonKills;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct TeamBansDto
    {
        public int PickTurn;
        public int ChampionId;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct ParticipantDto
    {
        public ParticipantStatsDto Stats;
        public int ParticipantId;
        public RuneDto[] Runes;
        public ParticipantTimelineDto Timeline;
        public int TeamId;
        public int Spell2Id;
        public MasteryDto[] Masteries;
        public string HighestAchievedSeasonTier;
        public int Spell1Id;
        public int ChampionId;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct ParticipantStatsDto
    {
        public long PhysicalDamageDealt;
        public int NeutralMinionsKilledTeamJungle;
        public long MagicDamageDealt;
        public int TotalPlayerScore;
        public int Deaths;
        public bool Win;
        public int NeutralMinionsKilledEnemyJungle;
        public int AltarsCaptured;
        public int LargestCriticalStrike;
        public long TotalDamageDealt;
        public long MagicDamageDealtToChampions;
        public int VisionWardsBoughtInGame;
        public long DamageDealtToObjectives;
        public int LargestKillingSpree;
        public int Item1;
        public int QuadraKills;
        public int TeamObjective;
        public int TotalTimeCrowdControlDealt;
        public int LongestTimeSpentLiving;
        public int WardsKilled;
        public bool FirstTowerAssist;
        public bool FirstTowerKill;
        public int Item2;
        public int Item3;
        public int Item0;
        public bool FirstBloodAssist;
        public long VisionScore;
        public int WardsPlaced;
        public int Item4;
        public int Item5;
        public int Item6;
        public int TurretKills;
        public int TripleKills;
        public long DamageSelfMitigated;
        public int ChampLevel;
        public int NodeNeutralizeAssist;
        public bool FirstInhibitorKill;
        public int GoldEarned;
        public long MagicalDamageTaken;
        public int Kills;
        public int DoubleKills;
        public int NodeCaptureAssist;
        public long TrueDamageTaken;
        public int NodeNeutralize;
        public bool FirstInhibitorAssist;
        public int Assists;
        public int UnrealKills;
        public int NeutralMinionsKilled;
        public int ObjectivePlayerScore;
        public int CombatPlayerScore;
        public long DamageDealtToTurrets;
        public int AltarsNeutralized;
        public long PhysicalDamageDealtToChampions;
        public int GoldSpent;
        public long TrueDamageDealt;
        public long TrueDamageDealtToChampions;
        public int ParticipantId;
        public int PentaKills;
        public long TotalHeal;
        public int TotalMinionsKilled;
        public bool FirstBloodKill;
        public int NodeCapture;
        public int LargestMultiKill;
        public int SightWardsBoughtInGame;
        public long TotalDamageDealtToChampions;
        public int TotalUnitsHealed;
        public int InhibitorKills;
        public int TotalScoreRank;
        public long TotalDamageTaken;
        public int KillingSprees;
        public long TimeCCingOthers;
        public long PhysicalDamageTaken;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct RuneDto
    {
        public int RuneId;
        public int Rank;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct ParticipantTimelineDto
    {
        public string Lane;
        public int ParticipantId;
        public IDictionary<string, double> CsDiffPerMinDeltas;
        public IDictionary<string, double> GoldPerMinDeltas;
        public IDictionary<string, double> XpDiffPerMinDeltas;
        public IDictionary<string, double> CreepsPerMinDeltas;
        public IDictionary<string, double> XpPerMinDeltas;
        public string Role;
        public IDictionary<string, double> DamageTakenDiffPerMinDeltas;
        public IDictionary<string, double> DamageTakenPerMinDeltas;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct MasteryDto
    {
        public int MasteryId;
        public int Rank;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct MatchlistDto
    {
        public MatchReferenceDto[] Matches;
        public int TotalGames;
        public int StartIndex;
        public int EndIndex;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct MatchReferenceDto
    {
        public string Lane;
        public long GameId;
        public int Champion;
        public string PlatformId;
        public int Season;
        public int Queue;
        public string Role;
        public long Timestamp;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct MatchTimelineDto
    {
        public MatchFrameDto[] Frames;
        public long FrameInterval;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct MatchFrameDto
    {
        public long Timestamp;
        public IDictionary<int, MatchParticipantFrameDto> ParticipantFrames;
        public MatchEventDto[] Events;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct MatchParticipantFrameDto
    {
        public int TotalGold;
        public int TeamScore;
        public int ParticipantId;
        public int Level;
        public int CurrentGold;
        public int MinionsKilled;
        public int DominionScore;
        public MatchPositionDto Position;
        public int Xp;
        public int JungleMinionsKilled;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct MatchPositionDto
    {
        public int Y;
        public int X;
    }
}

// match-v3
namespace MingweiSamuel.Camille.Match
{
    public struct MatchEventDto
    {
        public string EventType;
        public string TowerType;
        public int TeamId;
        public string AscendedType;
        public int KillerId;
        public string LevelUpType;
        public string PointCaptured;
        public int[] AssistingParticipantIds;
        public string WardType;
        public string MonsterType;
        public string Type;
        public int SkillSlot;
        public int VictimId;
        public long Timestamp;
        public int AfterId;
        public string MonsterSubType;
        public string LaneType;
        public int ItemId;
        public int ParticipantId;
        public string BuildingType;
        public int CreatorId;
        public MatchPositionDto Position;
        public int BeforeId;
    }
}

// spectator-v3
namespace MingweiSamuel.Camille.Spectator
{
    public struct CurrentGameInfo
    {
        public long GameId;
        public long GameStartTime;
        public string PlatformId;
        public string GameMode;
        public long MapId;
        public string GameType;
        public BannedChampion[] BannedChampions;
        public Observer Observers;
        public CurrentGameParticipant[] Participants;
        public long GameLength;
        public long GameQueueConfigId;
    }
}

// spectator-v3
namespace MingweiSamuel.Camille.Spectator
{
    public struct BannedChampion
    {
        public int PickTurn;
        public long ChampionId;
        public long TeamId;
    }
}

// spectator-v3
namespace MingweiSamuel.Camille.Spectator
{
    public struct Observer
    {
        public string EncryptionKey;
    }
}

// spectator-v3
namespace MingweiSamuel.Camille.Spectator
{
    public struct CurrentGameParticipant
    {
        public long ProfileIconId;
        public long ChampionId;
        public string SummonerName;
        public GameCustomizationObject[] GameCustomizationObjects;
        public bool Bot;
        public Perks Perks;
        public long Spell2Id;
        public long TeamId;
        public long Spell1Id;
        public long SummonerId;
    }
}

// spectator-v3
namespace MingweiSamuel.Camille.Spectator
{
    public struct GameCustomizationObject
    {
        public string Category;
        public string Content;
    }
}

// spectator-v3
namespace MingweiSamuel.Camille.Spectator
{
    public struct Perks
    {
        public long PerkStyle;
        public long[] PerkIds;
        public long PerkSubStyle;
    }
}

// spectator-v3
namespace MingweiSamuel.Camille.Spectator
{
    public struct FeaturedGames
    {
        public long ClientRefreshInterval;
        public FeaturedGameInfo[] GameList;
    }
}

// spectator-v3
namespace MingweiSamuel.Camille.Spectator
{
    public struct FeaturedGameInfo
    {
        public long GameId;
        public long GameStartTime;
        public string PlatformId;
        public string GameMode;
        public long MapId;
        public string GameType;
        public BannedChampion[] BannedChampions;
        public Observer Observers;
        public Participant[] Participants;
        public long GameLength;
        public long GameQueueConfigId;
    }
}

// spectator-v3
namespace MingweiSamuel.Camille.Spectator
{
    public struct Participant
    {
        public long ProfileIconId;
        public long ChampionId;
        public string SummonerName;
        public bool Bot;
        public long Spell2Id;
        public long TeamId;
        public long Spell1Id;
    }
}

// summoner-v3
namespace MingweiSamuel.Camille.Summoner
{
    /// represents a summoner
    public struct Summoner
    {
        public int ProfileIconId;
        public string Name;
        public long SummonerLevel;
        public long RevisionDate;
        public long Id;
        public long AccountId;
    }
}

// tournament-stub-v3
namespace MingweiSamuel.Camille.TournamentStub
{
    public struct TournamentCodeParameters
    {
        public string SpectatorType;
        public int TeamSize;
        public string PickType;
        public SummonerIdParams AllowedSummonerIds;
        public string MapType;
        public string Metadata;
    }
}

// tournament-stub-v3
namespace MingweiSamuel.Camille.TournamentStub
{
    public struct SummonerIdParams
    {
        public long[] Participants;
    }
}

// tournament-stub-v3
namespace MingweiSamuel.Camille.TournamentStub
{
    public struct LobbyEventDTOWrapper
    {
        public LobbyEvent[] EventList;
    }
}

// tournament-stub-v3
namespace MingweiSamuel.Camille.TournamentStub
{
    public struct LobbyEvent
    {
        public string EventType;
        public string SummonerId;
        public string Timestamp;
    }
}

// tournament-stub-v3
namespace MingweiSamuel.Camille.TournamentStub
{
    public struct ProviderRegistrationParameters
    {
        public string Url;
        public string Region;
    }
}

// tournament-stub-v3
namespace MingweiSamuel.Camille.TournamentStub
{
    public struct TournamentRegistrationParameters
    {
        public int ProviderId;
        public string Name;
    }
}

// tournament-v3
namespace MingweiSamuel.Camille.Tournament
{
    public struct TournamentCodeParameters
    {
        public string SpectatorType;
        public int TeamSize;
        public string PickType;
        public SummonerIdParams AllowedSummonerIds;
        public string MapType;
        public string Metadata;
    }
}

// tournament-v3
namespace MingweiSamuel.Camille.Tournament
{
    public struct SummonerIdParams
    {
        public long[] Participants;
    }
}

// tournament-v3
namespace MingweiSamuel.Camille.Tournament
{
    public struct TournamentCodeUpdateParameters
    {
        public string SpectatorType;
        public string PickType;
        public string AllowedParticipants;
        public string MapType;
    }
}

// tournament-v3
namespace MingweiSamuel.Camille.Tournament
{
    public struct TournamentCode
    {
        public string Map;
        public string Code;
        public string Spectators;
        public string Region;
        public int ProviderId;
        public int TeamSize;
        public long[] Participants;
        public string PickType;
        public int TournamentId;
        public string LobbyName;
        public string Password;
        public int Id;
        public string MetaData;
    }
}

// tournament-v3
namespace MingweiSamuel.Camille.Tournament
{
    public struct LobbyEventDTOWrapper
    {
        public LobbyEvent[] EventList;
    }
}

// tournament-v3
namespace MingweiSamuel.Camille.Tournament
{
    public struct LobbyEvent
    {
        public string EventType;
        public string SummonerId;
        public string Timestamp;
    }
}

// tournament-v3
namespace MingweiSamuel.Camille.Tournament
{
    public struct ProviderRegistrationParameters
    {
        public string Url;
        public string Region;
    }
}

// tournament-v3
namespace MingweiSamuel.Camille.Tournament
{
    public struct TournamentRegistrationParameters
    {
        public int ProviderId;
        public string Name;
    }
}
#endregion
