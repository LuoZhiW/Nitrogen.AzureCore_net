using System.Web;

namespace Nitrogen.Foundation.Util.Web
{
    public static class LoginUserInfo
    {
        public static UserInfo Get()
        {
            return (UserInfo)HttpContext.Current.Items[ConstantName.LoginUserInfo];
        }
    }
}
