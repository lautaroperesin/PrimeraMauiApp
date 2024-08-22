using System.Collections.ObjectModel;

namespace PrimeraMauiApp.Pages;

public partial class ControlesComunesPage : ContentPage
{
    public ObservableCollection<string> Frutas { get; set; }

    public ControlesComunesPage()
	{
		InitializeComponent();
        Frutas = new ObservableCollection<string>
        {
            "Apple",
            "Banana",
            "Orange",
            "Grape",
            "Pineapple",
            "Strawberry",
            "Mango",
            "Peach",
            "Cherry",
            "Watermelon"
        };
        BindingContext = this;
    }
}