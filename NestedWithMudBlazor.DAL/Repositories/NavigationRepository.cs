using NestedWithMudBlazor.DAL.Interfaces;
using NestedWithMudBlazor.DAL.Models;

namespace NestedWithMudBlazor.DAL.Repositories
{
	public class NavigationRepository : INavigationRepository
	{
		private readonly List<Data_NavLink> _navLinks = [];
		public NavigationRepository()
		{
			_navLinks = SeedData.GetNavigations();
			OrderChildLinks();
		}

		private void OrderChildLinks()
		{
			// EFCore typically does this part with the proper setup. Doing it manually for display purposes
			foreach (Data_NavLink item in _navLinks.Where(x => x.ParentId == null).ToList())
			{
				item.ChildNavLinks = [];
				item.ChildNavLinks.AddRange(_navLinks.Where(x => x.ParentId == item.NavLinkId));
			}
		}

		public async Task<List<Data_NavLink>> GetNavigationMenuAsync()
		{
			await Task.CompletedTask;
			var menuItems = _navLinks
				.OrderBy(m => !m.ParentId.HasValue ? int.MaxValue : m.ParentId) // Handle null ParentId which will ensure parent's are sorted by orderbyId
				.ThenBy(m => m.OrderById) // sort children by orderbyID
				.ToList();
			return menuItems;
		}

		public async Task<OperationResult<Data_NavLink>> AddUpdateNavLink(Data_NavLink navLink)
		{
			await Task.CompletedTask;
			if (navLink.NavLinkId == 0)
			{
				_navLinks.Add(navLink);
			}
			else
			{
				var nav = _navLinks.FirstOrDefault(x => x.NavLinkId == navLink.NavLinkId);
				if (nav != null)
				{
					_navLinks.Remove(nav);
					_navLinks.Add(navLink);
					OrderChildLinks();
				}
				else
				{
					return OperationResult<Data_NavLink>.FailureResult($"Error adding/updating navigation link: {navLink.Title}", string.Empty);
				}
			}

			return OperationResult<Data_NavLink>.SuccessResult(navLink, $"Successful add/update of {navLink.Title}");
		}

		public async Task<OperationResult<Data_NavLink>> RemoveNavLink(int navLinkId)
		{
			await Task.CompletedTask;

			// get entity and ensure valid then remove it 
			var entity = _navLinks.FirstOrDefault(x => x.NavLinkId == navLinkId);
			if (entity != null)
			{
				_navLinks.Remove(entity);
				OrderChildLinks();
			}
			else
			{
				return OperationResult<Data_NavLink>.FailureResult($"Error removing navigation link: {navLinkId}", string.Empty);
			}
			return OperationResult<Data_NavLink>.SuccessResult(entity!, $"Successful deletion of {entity!.Title}, Id: {navLinkId}");
		}

	}
}
