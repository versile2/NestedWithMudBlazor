using Microsoft.AspNetCore.Components;

namespace NestedWithMudBlazor.UI.Components.Pages
{
	public partial class Error
	{
		[Parameter]
		public Exception Exception { get; set; } = default!;

		private string _message = string.Empty;
		private string _stackTrace = string.Empty;

		protected override void OnAfterRender(bool firstRender)
		{
			if (firstRender)
			{
				StateHasChanged();
			}
#if (DEBUG)
			if (Exception != null)
			{
				_message = Exception.Message;
				_stackTrace = Exception.StackTrace;
			}
#endif
		}

	}
}