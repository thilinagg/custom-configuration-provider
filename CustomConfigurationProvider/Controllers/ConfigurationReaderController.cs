using CustomConfigurationProvider.CustomConfigurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CustomConfigurationProvider.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConfigurationReaderController : ControllerBase
{
    private readonly CustomAppSettingModel _customAppSetting;

    public ConfigurationReaderController(IOptionsSnapshot<CustomAppSettingModel> customAppSettingSnapshot)
    {
        _customAppSetting = customAppSettingSnapshot.Value;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var appSettings = new List<string>
        {
            _customAppSetting.ApiKey,
            _customAppSetting.ApiSecret
        };
        
        return Ok(appSettings);
    }
}
