namespace CustomConfigurationProvider.CustomConfigurations;

public static class CustomConfigurationExtensions
{
    public static IConfigurationBuilder AddCustomAppSettings(this IConfigurationBuilder builder)
    {
        return builder.Add(new CustomConfigurationSource());
    }
}