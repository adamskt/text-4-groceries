
using TextForGroceries.Client.ViewModels;

public static class ViewModels
{

    public static IServiceCollection AddViewModels(
        this IServiceCollection services)
    {

        return services.AddTransient<IndexViewModel>();
    }
}