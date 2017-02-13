using System.Collections.Generic;
using System.Configuration;


namespace CustomConfiguration
{
    public class CustomConfiguration : ConfigurationSection
    {
        public static CustomConfiguration _Config = ConfigurationManager.GetSection("adminion_settings") as CustomConfiguration;
        
        public static CustomConfiguration GetSetting
        {
            get
            {
                return _Config;
            }
        }
    }
}