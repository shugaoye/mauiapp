using Microsoft.AspNetCore.Components;
using System.Diagnostics;

using Microsoft.AspNetCore.Components.Web;

namespace MauiApp1.Pages;

public partial class Login : ComponentBase
{
    //[Inject]
    //private NavigationManager navigationManager { get; set; } = default!;

    private async void OnLogin(MouseEventArgs e)
    {
        //navigationManager.NavigateTo("/about");
        await Shell.Current.GoToAsync($"//MainPage");
        Debug.WriteLine($"Login clicked and invoke GoToAsync");
    }
}