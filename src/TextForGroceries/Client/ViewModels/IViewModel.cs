using System.ComponentModel;

namespace TextForGroceries.Client.ViewModels;

public interface IViewModel : INotifyPropertyChanged
{
    Task OnInitializedAsync();
    Task Loaded();
}