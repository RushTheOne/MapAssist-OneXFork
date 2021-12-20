/**
 *   Copyright (C) 2021 okaygo
 *
 *   https://github.com/misterokaygo/MapAssist/
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 **/

using System.Drawing;
using MapAssist.Files;
using MapAssist.Helpers;
using MapAssist.Settings;
using MapAssist.Types;
using YamlDotNet.Serialization;

namespace MapAssist.Settings
{
    public class MapAssistConfiguration
    {
        public static MapAssistConfiguration Loaded { get; set; }
        public static void Load()
        {
            Loaded = ConfigurationParser<MapAssistConfiguration>.ParseConfigurationMain(Properties.Resources.Config, $"./Config.yaml");
            Languages.LoadAreaLocalization();
            Languages.LoadShrineLocalization();
        }

        public void Save()
        {
            new ConfigurationParser<MapAssistConfiguration>().SerializeToFile(this);
        }

        [YamlMember(Alias = "UpdateTime", ApplyNamingConventions = false)]
        public int UpdateTime { get; set; }
        
        [YamlMember(Alias = "D2Path", ApplyNamingConventions = false)]
        public string D2Path { get; set; }

        [YamlMember(Alias = "PrefetchAreas", ApplyNamingConventions = false)]
        public Area[] PrefetchAreas { get; set; }

        [YamlMember(Alias = "HiddenAreas", ApplyNamingConventions = false)]
        public Area[] HiddenAreas { get; set; }

        [YamlMember(Alias = "ClearPrefetchedOnAreaChange", ApplyNamingConventions = false)]
        public bool ClearPrefetchedOnAreaChange { get; set; }

        [YamlMember(Alias = "RenderingConfiguration", ApplyNamingConventions = false)]
        public RenderingConfiguration RenderingConfiguration { get; set; }

        [YamlMember(Alias = "MapConfiguration", ApplyNamingConventions = false)]
        public MapConfiguration MapConfiguration { get; set; }

        [YamlMember(Alias = "MapColorConfiguration", ApplyNamingConventions = false)]
        public MapColorConfiguration MapColorConfiguration { get; set; }

        [YamlMember(Alias = "HotkeyConfiguration", ApplyNamingConventions = false)]
        public HotkeyConfiguration HotkeyConfiguration { get; set; }

        [YamlMember(Alias = "GameInfo", ApplyNamingConventions = false)]
        public GameInfoConfiguration GameInfo { get; set; }

        [YamlMember(Alias = "ItemLog", ApplyNamingConventions = false)]
        public ItemLogConfiguration ItemLog { get; set; }

        [YamlMember(Alias = "Language", ApplyNamingConventions = false)]
        public int Language { get; set; }
    }

    public class MapColorConfiguration
    {
        
        [YamlMember(Alias = "Walkable", ApplyNamingConventions = false)]
        public Color? Walkable { get; set; }
        
        [YamlMember(Alias = "Border", ApplyNamingConventions = false)]
        public Color? Border { get; set; }
    }

    public class MapConfiguration
    {
        [YamlMember(Alias = "SuperUniqueMonster", ApplyNamingConventions = false)]
        public IconRendering SuperUniqueMonster { get; set; }
        public static IconRendering SuperUniqueMonsterREF => MapAssistConfiguration.Loaded.MapConfiguration.SuperUniqueMonster;

        [YamlMember(Alias = "UniqueMonster", ApplyNamingConventions = false)]
        public IconRendering UniqueMonster { get; set; }
        public static IconRendering UniqueMonsterREF => MapAssistConfiguration.Loaded.MapConfiguration.UniqueMonster;

        [YamlMember(Alias = "EliteMonster", ApplyNamingConventions = false)]
        public IconRendering EliteMonster { get; set; }
        public static IconRendering EliteMonsterREF => MapAssistConfiguration.Loaded.MapConfiguration.EliteMonster;

        [YamlMember(Alias = "NormalMonster", ApplyNamingConventions = false)]
        public IconRendering NormalMonster { get; set; }
        public static IconRendering NormalMonsterREF => MapAssistConfiguration.Loaded.MapConfiguration.NormalMonster;

        [YamlMember(Alias = "NextArea", ApplyNamingConventions = false)]
        public PointOfInterestRendering NextArea { get; set; }
        public static PointOfInterestRendering NextAreaREF => MapAssistConfiguration.Loaded.MapConfiguration.NextArea;

        [YamlMember(Alias = "PreviousArea", ApplyNamingConventions = false)]
        public PointOfInterestRendering PreviousArea { get; set; }
        public static PointOfInterestRendering PreviousAreaREF => MapAssistConfiguration.Loaded.MapConfiguration.PreviousArea;

        [YamlMember(Alias = "Waypoint", ApplyNamingConventions = false)]
        public PointOfInterestRendering Waypoint { get; set; }
        public static PointOfInterestRendering WaypointREF => MapAssistConfiguration.Loaded.MapConfiguration.Waypoint;

        [YamlMember(Alias = "Quest", ApplyNamingConventions = false)]
        public PointOfInterestRendering Quest { get; set; }
        public static PointOfInterestRendering QuestREF => MapAssistConfiguration.Loaded.MapConfiguration.Quest;

        [YamlMember(Alias = "Player", ApplyNamingConventions = false)]
        public PointOfInterestRendering Player { get; set; }
        public static PointOfInterestRendering PlayerREF => MapAssistConfiguration.Loaded.MapConfiguration.Player;

        [YamlMember(Alias = "NonPartyPlayer", ApplyNamingConventions = false)]
        public PointOfInterestRendering NonPartyPlayer { get; set; }
        public static PointOfInterestRendering NonPartyPlayerREF => MapAssistConfiguration.Loaded.MapConfiguration.NonPartyPlayer;

        [YamlMember(Alias = "HostilePlayer", ApplyNamingConventions = false)]
        public PointOfInterestRendering HostilePlayer { get; set; }

        [YamlMember(Alias = "Portal", ApplyNamingConventions = false)]
        public PortalRendering Portal { get; set; }
        public static PortalRendering PortalREF => MapAssistConfiguration.Loaded.MapConfiguration.Portal;

        [YamlMember(Alias = "SuperChest", ApplyNamingConventions = false)]
        public PointOfInterestRendering SuperChest { get; set; }
        public static PointOfInterestRendering SuperChestREF => MapAssistConfiguration.Loaded.MapConfiguration.SuperChest;

        [YamlMember(Alias = "NormalChest", ApplyNamingConventions = false)]
        public PointOfInterestRendering NormalChest { get; set; }
        public static PointOfInterestRendering NormalChestREF => MapAssistConfiguration.Loaded.MapConfiguration.NormalChest;

        [YamlMember(Alias = "LockedChest", ApplyNamingConventions = false)]
        public PointOfInterestRendering LockedChest { get; set; }

        [YamlMember(Alias = "TrappedChest", ApplyNamingConventions = false)]
        public PointOfInterestRendering TrappedChest { get; set; }

        [YamlMember(Alias = "Shrine", ApplyNamingConventions = false)]
        public PointOfInterestRendering Shrine { get; set; }
        public static PointOfInterestRendering ShrineREF => MapAssistConfiguration.Loaded.MapConfiguration.Shrine;

        [YamlMember(Alias = "ArmorWeapRack", ApplyNamingConventions = false)]
        public PointOfInterestRendering ArmorWeapRack { get; set; }
        public static PointOfInterestRendering ArmorWeapRackREF => MapAssistConfiguration.Loaded.MapConfiguration.ArmorWeapRack;

        [YamlMember(Alias = "Item", ApplyNamingConventions = false)]
        public PointOfInterestRendering Item { get; set; }
        public static PointOfInterestRendering ItemREF => MapAssistConfiguration.Loaded.MapConfiguration.Item;
    }
}

public class RenderingConfiguration
{
    [YamlMember(Alias = "Opacity", ApplyNamingConventions = false)]
    public float Opacity { get; set; }

    [YamlMember(Alias = "IconOpacity", ApplyNamingConventions = false)]
    public float IconOpacity { get; set; }

    [YamlMember(Alias = "OverlayMode", ApplyNamingConventions = false)]
    public bool OverlayMode { get; set; }

    [YamlMember(Alias = "ToggleViaInGameMap", ApplyNamingConventions = false)]
    public bool ToggleViaInGameMap { get; set; }

    [YamlMember(Alias = "ToggleViaInGamePanels", ApplyNamingConventions = false)]
    public bool ToggleViaInGamePanels { get; set; }

    [YamlMember(Alias = "Size", ApplyNamingConventions = false)]
    public int Size { get; set; }
    public int InitialSize { get; set; }

    [YamlMember(Alias = "Position", ApplyNamingConventions = false)]
    public MapPosition Position { get; set; }

    [YamlMember(Alias = "BuffPosition", ApplyNamingConventions = false)]
    public BuffPosition BuffPosition { get; set; }

    [YamlMember(Alias = "BuffSize", ApplyNamingConventions = false)]
    public float BuffSize { get; set; }

    [YamlMember(Alias = "ZoomLevel", ApplyNamingConventions = false)]
    public float ZoomLevel { get; set; }
}

public class HotkeyConfiguration
{
    [YamlMember(Alias = "ToggleKey", ApplyNamingConventions = false)]
    public string ToggleKey { get; set; }

    [YamlMember(Alias = "ZoomInKey", ApplyNamingConventions = false)]
    public string ZoomInKey { get; set; }

    [YamlMember(Alias = "ZoomOutKey", ApplyNamingConventions = false)]
    public string ZoomOutKey { get; set; }

    [YamlMember(Alias = "AreaLevelKey", ApplyNamingConventions = false)]
    public string AreaLevelKey { get; set; }
}

public class GameInfoConfiguration
{
    [YamlMember(Alias = "ShowGameIP", ApplyNamingConventions = false)]
    public bool ShowGameIP { get; set; }

    [YamlMember(Alias = "HuntingIP", ApplyNamingConventions = false)]
    public string HuntingIP { get; set; }

    [YamlMember(Alias = "ShowAreaLevel", ApplyNamingConventions = false)]
    public bool ShowAreaLevel { get; set; }

    [YamlMember(Alias = "ShowOverlayFPS", ApplyNamingConventions = false)]
    public bool ShowOverlayFPS { get; set; }
    
    [YamlMember(Alias = "LabelFont", ApplyNamingConventions = false)]
    public string LabelFont { get; set; }

    [YamlMember(Alias = "LabelFontSize", ApplyNamingConventions = false)]
    public int LabelFontSize { get; set; }
}

public class ItemLogConfiguration
{
    [YamlMember(Alias = "Enabled", ApplyNamingConventions = false)]
    public bool Enabled { get; set; }

    [YamlMember(Alias = "FilterFileName", ApplyNamingConventions = false)]
    public string FilterFileName { get; set; }

    [YamlMember(Alias = "PlaySoundOnDrop", ApplyNamingConventions = false)]
    public bool PlaySoundOnDrop { get; set; }

    [YamlMember(Alias = "DisplayForSeconds", ApplyNamingConventions = false)]
    public double DisplayForSeconds { get; set; }
    [YamlMember(Alias = "SoundFile", ApplyNamingConventions = false)]
    public string SoundFile { get; set; }

    [YamlMember(Alias = "LabelFont", ApplyNamingConventions = false)]
    public string LabelFont { get; set; }

    [YamlMember(Alias = "LabelFontSize", ApplyNamingConventions = false)]
    public float LabelFontSize { get; set; }
}
