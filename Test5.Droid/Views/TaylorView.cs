using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using Test5.Core.ViewModels;

namespace Test5.Droid.Views
{
    [Activity(Label = "@string/app_name")]
    internal class TaylorView : MvxActivity<TaylorViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TaylorPage);
        }
    }

}