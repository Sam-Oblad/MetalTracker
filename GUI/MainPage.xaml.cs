using System.Diagnostics;
using InventoryTracker;
using Models;

namespace GUI
{
    public partial class MainPage : ContentPage
    {
        MetalInventoryTracker inventory;
        MetalType metal;
        public MainPage()
        {
            InitializeComponent();
            inventory = new();
            metal = new("Silver");
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
            Table.Children.Clear();
            foreach (InventoryEntry entry in inventory.metalInventory)
            {
                Label label = new Label();
                label.TextColor = Colors.Black;
                label.Text = $"Date: {entry.dateAcquired} Ounces: {entry.ounces} Price: {entry.amountPaid} Location:{entry.location}";
                Table.Add(label);
            }
            ClearAddEntryBoxes();
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
            if (float.TryParse(QuantityEntry.Text, out float ounces) && float.TryParse(PriceEntry.Text, out float price)){
                InventoryEntry entry = new(DateEntry.Text, metal, ounces, price, LocationEntry.Text);
                inventory.addEntry(entry);
                ChangeToInventoryPage();
            }
            else
            {
                ChangeToInventoryPage();
                ///TODO: Add message for error parsing float. 
            }

        }

        private void ClearAddEntryBoxes()
        {
            DateEntry.Text = "";
            QuantityEntry.Text = "";
            PriceEntry.Text = "";
            LocationEntry.Text = "";

        }

    }
}
