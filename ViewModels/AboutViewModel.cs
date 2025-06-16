using System.Collections.ObjectModel;
using System.Windows.Input;
using Cisneros_Cahueñas_Puga_Notes.Models;
using CommunityToolkit.Mvvm.Input;

namespace Cisneros_Cahueñas_Puga_Notes.ViewModels;

internal class AboutViewModel
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui"; 
    public ICommand ShowMoreInfoCommand { get; }

    public AboutViewModel()
    {
        ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfo);
    }

    async Task ShowMoreInfo() =>
        await Launcher.Default.OpenAsync(MoreInfoUrl);
    
    public ObservableCollection<TeamMember> TeamMembers { get; } = new()
    {
        new TeamMember { Nombre = "David Puga", Edad = 20, DeporteFavorito = "Fútbol", Photo = "photo2.jpeg" },
        new TeamMember { Nombre = "Alexander Cahueñas", Edad = 21, DeporteFavorito = "Basquetball", Photo = "photo1.jpeg" },
        new TeamMember { Nombre = "Mateo Cisneros", Edad = 20, DeporteFavorito = "F1", Photo = "photo3.jpeg" }
    };
}