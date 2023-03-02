using System;
using System.Collections.Generic;
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

namespace Interface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startVideoBtn_Click(object sender, RoutedEventArgs e)
        {
            videoOnePeace.Play();
        }

        private void StopVideoBtn_Click(object sender, RoutedEventArgs e)
        {
            videoOnePeace.Pause();
        }

        private void whoIsLuffy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Монки Д. Луффи — главный герой аниме и манги One Piece. Основатель капитан Пиратов Соломенной Шляпы");
        }

        private void funnyThing_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Неважно, возможно это или нет. Я это сделаю, потому что хочу сделать. - Монки Д Луффи");
        }
    }
}
