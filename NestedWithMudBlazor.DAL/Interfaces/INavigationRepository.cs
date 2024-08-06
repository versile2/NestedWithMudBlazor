using NestedWithMudBlazor.DAL.Models;

namespace NestedWithMudBlazor.DAL.Interfaces
{
	public interface INavigationRepository
	{
		public Task<List<Data_NavLink>> GetNavigationMenuAsync();
		public Task<OperationResult<Data_NavLink>> AddUpdateNavLink(Data_NavLink navLink);
		public Task<OperationResult<Data_NavLink>> RemoveNavLink(int navLinkId);
	}
}