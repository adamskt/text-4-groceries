using Microsoft.AspNetCore.Components;
using TextForGroceries.Client.ViewModels;

namespace TextForGroceries.Client.Components;

public abstract class ComponentBase<TViewModel> : ComponentBase
    where TViewModel : IViewModel
{
    [Inject]
#pragma warning disable CS8618
    protected TViewModel ViewModel { get; set; }
#pragma warning restore CS8618

    protected override void OnInitialized()
    {
        ViewModel.PropertyChanged += (_, _) => StateHasChanged();
        base.OnInitialized();
    }

    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        return base.OnAfterRenderAsync(firstRender);
    }

    protected override Task OnInitializedAsync()
    {
        return ViewModel.OnInitializedAsync();
    }
}