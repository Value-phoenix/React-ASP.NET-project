namespace ReactApp_ASP.NET.Server
{
    public class TenantService
    {
        private List<Tenant> tenants;

        public TenantService()
        {
            // Initialize the list of tenants
            tenants = new List<Tenant>
        {
            new Tenant { Id = 1, Host = "example1.com", IsActive = true, ThemeName = "Theme1" },
            new Tenant { Id = 2, Host = "example2.com", IsActive = true, ThemeName = "Theme2" }
            // Add more hard-coded tenants as needed
        };
        }

        // Method to retrieve all tenants
        public List<Tenant> GetAllTenants()
        {
            return tenants;
        }

        // Method to add a new tenant
        public void AddTenant(Tenant newTenant)
        {
            tenants.Add(newTenant);
        }

        // Method to update an existing tenant
        public void UpdateTenant(int tenantId, Tenant updatedTenant)
        {
            var existingTenant = tenants.FirstOrDefault(t => t.Id == tenantId);
            if (existingTenant != null)
            {
                existingTenant.Host = updatedTenant.Host;
                existingTenant.IsActive = updatedTenant.IsActive;
                existingTenant.ThemeName = updatedTenant.ThemeName;
            }
        }

        // Method to delete a tenant by Id
        public void DeleteTenant(int tenantId)
        {
            var tenantToRemove = tenants.FirstOrDefault(t => t.Id == tenantId);
            if (tenantToRemove != null)
            {
                tenants.Remove(tenantToRemove);
            }
        }
    }

}
