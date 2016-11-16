using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using LanguageFlashCards.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace LanguageFlashCards.Android.Views {
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxTabActivity {
        protected FirstViewModel FirstViewModel {
            get { return base.ViewModel as FirstViewModel; }
        }

        protected override void OnCreate(Bundle bundle) {

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            TabHost.TabSpec spec;
            Intent intent;

            spec = TabHost.NewTabSpec("hiraganaChild");
            spec.SetIndicator("Hiragana");
            spec.SetContent(this.CreateIntentFor(FirstViewModel.HiraganaChild));
            TabHost.AddTab(spec);

            spec = TabHost.NewTabSpec("katakanaChild");
            spec.SetIndicator("Katakana");
            spec.SetContent(this.CreateIntentFor(FirstViewModel.KatakanaChild));
            TabHost.AddTab(spec);

            spec = TabHost.NewTabSpec("kanjiChild");
            spec.SetIndicator("Kanji");
            spec.SetContent(this.CreateIntentFor(FirstViewModel.KanjiChild));
            TabHost.AddTab(spec);
        }
    }

    [Activity(Label = "View for HiraganaViewModel")]
    public class HiraganaChildView : MvxTabActivity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HiraganaChildView);
        }
    }

    [Activity(Label = "View for KatakanaViewModel")]
    public class KatakanaChildView : MvxTabActivity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.KatakanaChildView);
        }
    }

    [Activity(Label = "View for KanjiViewModel")]
    public class KanjiChildView : MvxTabActivity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.KanjiChildView);
        }
    }
}
