using MvvmCross.Core.ViewModels;

namespace LanguageFlashCards.Core.ViewModels {
    public class FirstViewModel : MvxViewModel {

        public FirstViewModel() {
            HiraganaChild = new HiraganaChildViewModel();
            KatakanaChild = new KatakanaChildViewModel();
            KanjiChild = new KanjiChildViewModel();
        }

        private HiraganaChildViewModel hiraganaChild;
        public HiraganaChildViewModel HiraganaChild {
            get { return hiraganaChild; }
            set { hiraganaChild = value; RaisePropertyChanged(() => HiraganaChild); }
        }

        private KatakanaChildViewModel katakanaChild;
        public KatakanaChildViewModel KatakanaChild {
            get { return katakanaChild; }
            set { katakanaChild = value; RaisePropertyChanged(() => KatakanaChild); }
        }

        private KanjiChildViewModel kanjiChild;
        public KanjiChildViewModel KanjiChild {
            get { return kanjiChild; }
            set { kanjiChild = value; RaisePropertyChanged(() => KanjiChild); }
        }
    }

    public class HiraganaChildViewModel : MvxViewModel {
        private string hiraganaTest = "Arrived at Hiragana tab";
        public string HiraganaTest {
            get { return hiraganaTest; }
            set { hiraganaTest = value; RaisePropertyChanged(() => HiraganaTest); }
        }
    }

    public class KatakanaChildViewModel : MvxViewModel {
        private string katakanaTest = "Arrived at Katakana tab";
        public string KatakanaTest {
            get { return katakanaTest; }
            set { katakanaTest = value; RaisePropertyChanged(() => KatakanaTest); }
        }
    }

    public class KanjiChildViewModel : MvxViewModel {
        private string kanjiTest = "Arrived at Hiragana tab";
        public string KanjiTest {
            get { return kanjiTest; }
            set { kanjiTest = value; RaisePropertyChanged(() => KanjiTest); }
        }
    }

}
