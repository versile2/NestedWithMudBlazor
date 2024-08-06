using MudBlazor;
using NestedWithMudBlazor.DAL.Models;

namespace NestedWithMudBlazor.DAL.Repositories
{
    public class SeedData
    {
        public static List<Data_NavLink> GetNavigations()
        {
            var navigations = new List<Data_NavLink>
            {
				// Home Navigation
				new() {
                            NavLinkId = 1,
                            Title = "Home",
                            Icon = Icons.Material.Filled.Home,
                            Href = " ",
                            OrderById = 0,
                },

				// Dropzone MudSimpleTable
						new() {
                            NavLinkId = 2,
                            Title = "Drop Zone",
                            Icon = Icons.Material.Filled.VerifiedUser,
                            Href = "dnd",
                            OrderById = 9,
                },

				// Investigation Database Navigation
						new() {
                            NavLinkId = 3,
                            Title = "Investigation Database",
                            Icon = Icons.Material.Filled.Anchor,
                            Role = "adminrole,investigativerole",
                            OrderById = 1
                },
				// Return to Apps Heirarchy Navigation
						new() {
                            NavLinkId = 4,
                            Title = "Return to Apps",
                            Icon = Icons.Material.Filled.KeyboardReturn,
                            OrderById = 99,
                },
                        new() {
                            NavLinkId = 5,
                            Title = "Dev Apps",
                            Href = "https://development.local",
                            Role = "adminrole",
                            IsNewWindow = true,
                            OrderById = 0,
                            ParentId = 4
                },
                        new() {
                            NavLinkId = 6,
                            Title = "Prod Apps",
                            Href = "https://production.local",
                            IsNewWindow = true,
                            OrderById = 1,
                            ParentId = 4
                },
                // Admin
                        new() {
                            NavLinkId = 7,
                            Title = "Admin",
                            Role = "adminrole",
                            Icon = Icons.Material.Filled.AdminPanelSettings,
                            OrderById = 98,
                },
                        new() {
                            NavLinkId= 8,
                            Title = "Navigation",
                            Href = "managenav",
                            Role = "adminrole",
                            OrderById = 0,
                            ParentId = 7,
                },
                // Investigation Database Navigation Sub 1
                        new()
                        {
                            NavLinkId = 9,
                            Title = "Incident Tracking",
                            ParentId = 3,
                            Href="investigationdatabase",
                            Role = "adminrole,investigativerole",
                            OrderById=0,
                },
                // Investigation Database Navigation Sub 2
                        new()
                        {
                            NavLinkId = 10,
                            Title = "Edit Agencies",
                            ParentId = 3,
                            Href="addedittrackeragency",
                            Role = "adminrole,investigativerole",
                            OrderById=0,
                },
                 // Investigation Database Navigation Sub 3
						new()
                        {
                            NavLinkId = 11,
                            Title = "Edit Employees",
                            ParentId = 3,
                            Href="addedittrackerentity",
                            Role = "adminrole,investigativerole",
                            OrderById=0,
                },
                 // DRS
						new()
                        {
                            NavLinkId = 12,
                            Title = "DRS",
                            Href="drs",
                            Role = "adminrole,drsrole",
                            OrderById=2,
                            Icon = $"<path d=\"M0 0h24v24H0z\" fill=\"none\"/><path d=\"M12 11.55C9.64 9.35 6.48 8 3 8v11c3.48 0 6.64 1.35 9 3.55 2.36-2.19 5.52-3.55 9-3.55V8c-3.48 0-6.64 1.35-9 3.55zM12 8c1.66 0 3-1.34 3-3s-1.34-3-3-3-3 1.34-3 3 1.34 3 3 3z\"/>",
                },
            };
            return navigations.OrderBy(x => x.NavLinkId).ToList();
        }
    }
}
