using ABP1st.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABP1st.Permissions;

public class ABP1stPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ABP1stPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ABP1stPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ABP1stResource>(name);
    }
}
