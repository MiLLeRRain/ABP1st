using Volo.Abp.Settings;

namespace ABP1st.Settings;

public class ABP1stSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ABP1stSettings.MySetting1));
    }
}
