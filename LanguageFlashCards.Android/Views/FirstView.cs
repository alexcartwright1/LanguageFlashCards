using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using LanguageFlashCards.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace LanguageFlashCards.Android.Views {
    [Activity(Label = "View for FirstViewModel")]
#pragma warning disable CS0618 // Type or member is obsolete
    public class FirstView : MvxTabActivity {
#pragma warning restore CS0618 // Type or member is obsolete
        protected FirstViewModel FirstViewModel {
            get { return base.ViewModel as FirstViewModel; }
        }

        protected override void OnCreate(Bundle bundle) {

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            TabHost.TabSpec spec;

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
    public class HiraganaChildView : MvxActivity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HiraganaChildView);
        }
    }

    [Activity(Label = "View for KatakanaViewModel")]
    public class KatakanaChildView : MvxActivity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.KatakanaChildView);
        }
    }

    [Activity(Label = "View for KanjiViewModel")]
    public class KanjiChildView : MvxActivity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.KanjiChildView);
        }
    }
}
