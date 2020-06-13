using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Test5.Core.ViewModels;

namespace Test5.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<TaylorViewModel>();
        }
    }
}