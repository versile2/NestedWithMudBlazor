# NestedWithMudBlazor

A concept application demonstrating specific usage patterns for Blazor, MudBlazor, MudBlazor Extensions, and Codebeam MudBlazor extensions. The application consists of two projects: the UI and the Data Access Layer.

## Concepts Demonstrated

* Wrapping `ProtectedBrowserStorage` in a service to enable unit testing of methods using it.
* Rendering nested hierarchical data for navigation links efficiently. (Note: Child properties are manually wrapped in the Navigation Repository as this application isn't connected to a database.)
* Implementing `MainLayout.razor` using MudBlazor, including all settings.
* Applying a custom MudBlazor theme.
* Implementing a dark/light toggle for the current MudBlazor theme.
* Displaying a loading screen during application startup.
* Customizing the `EditTemplate` for `EditMode.Form` (`DataGridEditMode.Form`) to modify specific controls on the automatic dialog form.
* Utilizing a `MudSwitch` to toggle the DataGrid between group and standard modes.

## Resources

* .NET 8
* Blazor Server Rendering
* CodeBeam.MudBlazor.Extensions (7.0.0)
* MudBlazor (7.5.0)
* MudBlazor.Extensions (2.0.2)

## Important Note

To wrap `ProtectedBrowserStorage` from a class library project, the project file must be edited to include the AspNetCore framework:

```xml
<ItemGroup>
    <FrameworkReference Include="Microsoft.AspNetCore.App" />
</ItemGroup>
