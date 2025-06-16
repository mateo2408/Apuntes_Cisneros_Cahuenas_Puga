using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace Cisneros_Cahueñas_Puga_Notes.ViewModels;

internal class AboutViewModel
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Message => "Nombre: David Puga\nEdad: 20\nDeporte favorito: fútbol \n" +
                             "Nombre: Alexander Cahueñas \nEdad: 21 \nDeporte favorito: basquetball \n" +
                             "Nombre: Mateo Cisneros \nEdad: 20 \nDeporte favorito: F1\n\n";
    public ICommand ShowMoreInfoCommand { get; }

    public AboutViewModel()
    {
        ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfo);
    }

    async Task ShowMoreInfo() =>
        await Launcher.Default.OpenAsync(MoreInfoUrl);
}