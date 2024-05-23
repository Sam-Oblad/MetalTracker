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
            //TODO: Popup alert in gui to ask for metal type and the such
            //InventoryEntry entry = new();
            //inventory.addEntry();
        }

        private void Save(Object Sender, EventArgs a)
        {

        }

        private void AddEntry(Object Sender, EventArgs a)
        {
            InventoryPage.IsVisible = false;
            AddEntryPage.IsVisible = true;
        }
    }
}
