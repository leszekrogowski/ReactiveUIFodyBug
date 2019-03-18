using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace ReactiveUIFodyBug
{
    public class MainViewModel : ReactiveObject
    {
        public MainViewModel()
        {
            this.WhenAnyValue(
                x => x.FirstName,
                x => x.LastName,
                (firstName, lastName) => $"{firstName} {lastName}")
                .ToPropertyEx(this, x => x.FullName);
        }

        [Reactive]
        public string FirstName { get; set; } = "Test 1";

        [Reactive]
        public string LastName { get; set; } = "Test 2";

        public extern string FullName { [ObservableAsProperty]get; }
    }
}