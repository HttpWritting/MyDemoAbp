using Abp.Web.Mvc.Views;

namespace MyDemoAbp.Web.Views
{
    public abstract class MyDemoAbpWebViewPageBase : MyDemoAbpWebViewPageBase<dynamic>
    {

    }

    public abstract class MyDemoAbpWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MyDemoAbpWebViewPageBase()
        {
            LocalizationSourceName = MyDemoAbpConsts.LocalizationSourceName;
        }
    }
}