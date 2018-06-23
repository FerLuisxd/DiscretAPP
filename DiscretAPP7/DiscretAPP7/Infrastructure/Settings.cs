using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace DiscretAPP7.Infrastructure
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string LastSecSetting = "";
        private static readonly string SettingsDefault = string.Empty;
        private const string LastOpion = "";
        private static readonly string DefaultOption = string.Empty;
        #endregion


        public static string LastUsedSec
        {
            get
            {
                return AppSettings.GetValueOrDefault(LastSecSetting, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(LastSecSetting, value);
            }
        }
        public static string LastOption
        {
            get
            {
                return AppSettings.GetValueOrDefault(LastOpion, DefaultOption);
            }
            set
            {
                AppSettings.AddOrUpdateValue(LastOpion, value);
            }
        }
    }
}