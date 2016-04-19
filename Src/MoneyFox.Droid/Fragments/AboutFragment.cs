using Android.OS;
using Android.Runtime;
using Android.Views;
using MoneyFox.Shared.ViewModels;
using MvvmCross.Droid.Shared.Attributes;

namespace MoneyFox.Droid.Fragments
{
    [MvxFragment(typeof (MainViewModel), Resource.Id.content_frame)]
    [Register("moneyfox.droid.fragments.AboutFragment")]
    public class AboutFragment : BaseFragment<AboutViewModel>
    {
        protected override int FragmentId => Resource.Layout.fragment_about;
    }
}