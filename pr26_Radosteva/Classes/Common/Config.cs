using Microsoft.EntityFrameworkCore;

namespace pr26_Radosteva.Classes.Common
{
    public class Config
    {
        public static readonly string connectionConfig = "server=localhost;uid=root;pwd=;database=pr26;";
        public static MySqlServerVersion version = new MySqlServerVersion(new Version(8,0,11));
    }
}
