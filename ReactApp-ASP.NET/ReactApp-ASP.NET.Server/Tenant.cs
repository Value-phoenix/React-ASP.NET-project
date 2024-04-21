namespace ReactApp_ASP.NET.Server
{
    public class Tenant
    {
        public int Id { get; set; }
        public string Host { get; set; }
        public bool IsActive { get; set; }
        public string ThemeName { get; set; }
    }

}
