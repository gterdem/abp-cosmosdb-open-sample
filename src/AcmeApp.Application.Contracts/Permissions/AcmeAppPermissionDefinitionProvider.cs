using AcmeApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AcmeApp.Permissions
{
    public class AcmeAppPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AcmeAppPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AcmeAppPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AcmeAppResource>(name);
        }
    }
}
