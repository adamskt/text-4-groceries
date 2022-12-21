
using TextForGroceries.Client.ViewModels;

namespace TextForGroceries.Client.DI;

public static class ViewModels
{

    public static IServiceCollection AddViewModels(
        this IServiceCollection services)
    {

        return services.AddTransient<IndexViewModel>();
    }
}