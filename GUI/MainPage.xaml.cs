using System.Diagnostics;

namespace GUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            InventoryPage.IsVisible = false;
        }

        private void OpenInventoryFile(Object Sender, EventArgs a)
        {
            ChangeToInventoryPage();
        }

        private void NewInventoryFile(Object Sender, EventArgs a)
        {
            ChangeToInventoryPage();
            OunceWidget.Text = " 0.00";
            PriceWidget.Text = " 0.00";
        }

        private void ChangeToInventoryPage()
        {
            WelcomePrompt.IsVisible = false;
            InventoryPage.IsVisible = true;
        }

        private void NewInventoryEntry(Object Sender, EventArgs a)
        {
        }

        private void Save(Object Sender, EventArgs a)
        {

        }

        private void AddEntry(Object Sender, EventArgs a)
        {

        }
    }
}
