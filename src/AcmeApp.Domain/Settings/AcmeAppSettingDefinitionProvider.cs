using Volo.Abp.Settings;

namespace AcmeApp.Settings
{
    public class AcmeAppSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AcmeAppSettings.MySetting1));
        }
    }
}
