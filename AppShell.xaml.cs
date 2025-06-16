using Cisneros_Cahueñas_Puga_Notes.Views;
using Microsoft.Maui.Controls;

namespace Cisneros_Cahueñas_Puga_Notes;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("NotePage", typeof(NotePage));
    }
}