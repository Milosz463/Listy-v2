using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<GraKomp> ListaGier { get; set; }
        public ObservableCollection<GraKomp> WybraneGry { get; set; }=new ObservableCollection<GraKomp>();
        public List<string> gatunki { get; set; } = new List<string>() { "rpg", "zrecznosciowa", "fantasy", "FPS" };
        public MainWindow()
        {
            InitializeComponent();
            KolumnaGatuenk.ItemsSource = gatunki;

            wypelnijDane();

            DataContext = this;
        }
        public void wypelnijDane()
        {
            ListaGier = new ObservableCollection<GraKomp>();
            ListaGier.Add(new GraKomp("CS2", "FPS", 18, true));
            ListaGier.Add(new GraKomp("Fortnie", "FPS", 12, true));
            ListaGier.Add(new GraKomp("Cyberpunk", "rpg", 18, false));
            ListaGier.Add(new GraKomp("Tetris", "zrecznosciowa", 6, false));
            ListaGier.Add(new GraKomp("LoL", "fantasy", 13, true));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nazwa = nazwagry.Text;
            string kategoria = GatunkiComboBox.Text;
            int wiek;
            if (int.TryParse(WiekTextBox.Text, out wiek))
            {
                if (Multi.IsChecked == true)
                {
                    ListaGier.Add(new GraKomp(nazwa, kategoria, wiek, true));
                }
                else
                {
                    ListaGier.Add(new GraKomp(nazwa, kategoria, wiek, false));
                }
            }
            else
            {
                MessageBox.Show("Wiek musi byc liczba");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string wybor=kategoria_combobox.Text;
            WybraneGry.Clear();
            for (int i = 0; i < ListaGier.Count; i++) {
                if (ListaGier[i].Gatunek == wybor)
                {
                    WybraneGry.Add(ListaGier[i]);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int wybranyIndeks;
            if (int.TryParse(doUsuniecia.Text, out wybranyIndeks))
            {
                for (int i = 0; i < ListaGier.Count; i++) {
                    if (ListaGier[i].Indeks == wybranyIndeks)
                    {
                        ListaGier.Remove(ListaGier[wybranyIndeks]);
                    }
            }
            }
        }
    }
}
