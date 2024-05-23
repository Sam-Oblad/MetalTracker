using System.Diagnostics;
using InventoryTracker;
using Models;

namespace GUI
{
    public partial class MainPage : ContentPage
    {
        MetalInventoryTracker inventory;
        public MainPage()
        {
            InitializeComponent();
            inventory = new();
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
            AddEntryPage.IsVisible = false;
            InventoryPage.IsVisible = true;
        }

        private void Save(Object Sender, EventArgs a)
        {

        }

        private void AddEntry(Object Sender, EventArgs a)
        {
            InventoryPage.IsVisible = false;
            AddEntryPage.IsVisible = true;
        }

        private void CancelEntry(Object sender, EventArgs a)
        {
            ChangeToInventoryPage();
        }

        private void FinishEntry(Object Sender, EventArgs a)
        {
            ChangeToInventoryPage();
        }

    }
}
