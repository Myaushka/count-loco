namespace CountLoco
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Windows.Controls;
    using CountLoco.Annotations;

    /// <summary>
    /// No patterns, just code-behind.
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        public MainWindow()
        {
            this.DataContext = this;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("is-IS");
            InitializeComponent();
        }

        public List<CultureInfo> Languages
        {
            get
            {
                List<CultureInfo> languages = new List<CultureInfo>
                {
                    new CultureInfo("en-US"),
                    new CultureInfo("ru-RU")
                };

                return languages;
            }
        }

        public string Things
        {
            get;
            private set;
        }

        private string number = string.Empty;

        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                this.number = value;
                this.Things = Pluralizer.GetFormattedStringForNumber(Strings.Things, this.number);
                this.OnPropertyChanged("Things");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handlerVMFactory = PropertyChanged;
            if (handlerVMFactory != null) handlerVMFactory(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnLanguageSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in e.AddedItems)
            {
                Strings.Culture = (CultureInfo) item;
                // RESET
                this.Number = this.Number;
            }
        }
    }
}