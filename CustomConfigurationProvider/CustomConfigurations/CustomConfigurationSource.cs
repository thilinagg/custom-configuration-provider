﻿namespace CustomConfigurationProvider.CustomConfigurations;

public class CustomConfigurationSource: IConfigurationSource
{
    public IConfigurationProvider Build(IConfigurationBuilder builder)
    {
        return new CustomConfigurationProvider();
    }
}