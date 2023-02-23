namespace CustomConfigurationProvider.CustomConfigurations;

public class CustomConfigurationProvider: ConfigurationProvider
{
    public override void Load()
    {
        Data = new Dictionary<string, string>
        {
            { "CustomAppSettingModel:ApiKey", "sample-api-key" },
            { "CustomAppSettingModel:ApiSecret", "sample-api-secret" }
        };
    }
}