using Microsoft.AspNetCore.Components;
using System.Diagnostics;

using Microsoft.AspNetCore.Components.Web;

namespace MauiApp1.Pages;

public partial class Login : ComponentBase
{
    [Inject]
    private NavigationManager navigationManager { get; set; } = default!;

    private void OnLogin(MouseEventArgs e)
    {
        navigationManager.NavigateTo("/about");
        Debug.WriteLine($"Login clicked");
    }
}