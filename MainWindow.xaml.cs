using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bugFontSize
{
  /// <summary>
  /// Lógica de interacción para MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    class Vehiculo
    {
      public DateTime Fecha { get; set; }
      public string Grupo { get; set; }
      public string Matricula { get; set; }
    }
    private static Random random = new Random();
    public string RandomMatricula()
    {
      const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      const string numbers = "1234567890";
      var letras = new string(Enumerable.Repeat(chars, 3)
        .Select(s => s[random.Next(s.Length)]).ToArray());
      var numeros = new string(Enumerable.Repeat(numbers, 4)
        .Select(s => s[random.Next(s.Length)]).ToArray());
      return numeros + "-" + letras;
    }
    public MainWindow()
    {
      InitializeComponent();

      var vehiculos = new List<Vehiculo>();
      vehiculos.Add(new Vehiculo { Grupo = "B", Fecha = DateTime.Now.AddDays(3), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "C", Fecha = DateTime.Now.AddMinutes(45), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "K", Fecha = DateTime.Now, Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "B", Fecha = DateTime.Now.AddDays(3), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "C", Fecha = DateTime.Now.AddMinutes(45), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "B", Fecha = DateTime.Now.AddDays(3), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "C", Fecha = DateTime.Now.AddMinutes(45), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "B", Fecha = DateTime.Now.AddDays(3), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "C", Fecha = DateTime.Now.AddMinutes(45), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "B", Fecha = DateTime.Now.AddDays(3), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "C", Fecha = DateTime.Now.AddMinutes(45), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "B", Fecha = DateTime.Now.AddDays(3), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "C", Fecha = DateTime.Now.AddMinutes(45), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "B", Fecha = DateTime.Now.AddDays(3), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "C", Fecha = DateTime.Now.AddMinutes(45), Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "K", Fecha = DateTime.Now, Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "K", Fecha = DateTime.Now, Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "K", Fecha = DateTime.Now, Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "K", Fecha = DateTime.Now, Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "K", Fecha = DateTime.Now, Matricula = RandomMatricula() });
      vehiculos.Add(new Vehiculo { Grupo = "K", Fecha = DateTime.Now, Matricula = RandomMatricula() });
      GrdALimpiar.ItemsSource = vehiculos;

    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
      Debug.WriteLine("+");
      Properties.Settings.Default.size += 2;
      Properties.Settings.Default.Save();
    }

    private void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
    {
      Debug.WriteLine("-");
      Properties.Settings.Default.size -= 2;
      Properties.Settings.Default.Save();
    }
  }
}
