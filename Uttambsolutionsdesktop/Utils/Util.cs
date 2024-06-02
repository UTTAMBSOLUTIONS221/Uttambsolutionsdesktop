using Microsoft.Extensions.Configuration;

namespace Uttambsolutionsdesktop.Utils
{
    public class Util
    {
        public static string ShareConnectionString(IConfiguration config)
        {
            return config["ConnectionStrings:DatabaseConnection"];
        }
    }
}
