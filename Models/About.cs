namespace Cisneros_Cahueñas_Puga_Notes.Models;

internal class About
{
    public string Title => "Mateo Cisneros";
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Message => "Programador, fanatico de Star Wars y amante de la tecnologia.\n\n" +
                             "Este es un proyecto de ejemplo para aprender a usar .NET MAUI, " +
                             "creado por el programador Cisneros.\n\n" +
                             "Para mas informacion visita el sitio web oficial de .NET MAUI.";
}