using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
//using static Android.Icu.Text.CaseMap;

namespace AppTemplate.Pages
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Ayes { get; set; }

        public int Nays { get; set; }

        public double AyesPercentage => (Ayes + Nays) == 0 ? 0 : (double)Ayes / (Ayes + Nays);

        public double NaysPercentage => (Ayes + Nays) == 0 ? 0 : (double)Nays / (Ayes + Nays);
        public Item(string name, string description, int ayes, int nays)
        {
            Name = name;
            Description = description;
            Ayes = ayes;
            Nays = nays;
        }
    }
    public partial class ProposalsPageViewModel : ObservableObject
    {


        [ObservableProperty]
        private ObservableCollection<Item> items = new ObservableCollection<Item>{
    new Item(
        name: "Clean Energy Initiative",
        description: "Proposal to increase investment in renewable energy infrastructure.",
        ayes: 120,
        nays: 30),

    new Item(
        name: "Universal Basic Income",
        description: "Proposal to implement a monthly basic income for all citizens.",
        ayes: 80,
        nays: 90),

    new Item(
        name: "Lower Voting Age",
        description: "Proposal to reduce the legal voting age to 16.",
        ayes: 60,
        nays: 140),

    new Item(
        name: "Digital Identity System",
        description: "Proposal to create a government-managed decentralized identity system.",
        ayes: 100,
        nays: 50),

    new Item(
        name: "Public Transportation Expansion",
        description: "Proposal to fund new high-speed rail and electric bus systems.",
        ayes: 150,
        nays: 45)
};
    }
}
