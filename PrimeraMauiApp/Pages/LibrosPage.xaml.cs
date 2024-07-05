using PrimeraMauiApp.Models;
using PrimeraMauiApp.Repositories;
using System.Collections.ObjectModel;

namespace PrimeraMauiApp.Pages;

public partial class LibrosPage : ContentPage
{
	Libro libroSeleccionado;
	LibrosRepositorio librosRepositorio = new LibrosRepositorio();
    ObservableCollection<Libro>? libros = new ObservableCollection<Libro>();

	public LibrosPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        libros = await librosRepositorio.ObtenerLibrosAsync();
        CollectionLibros.ItemsSource = libros;
    }
    private void btnVolver_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}