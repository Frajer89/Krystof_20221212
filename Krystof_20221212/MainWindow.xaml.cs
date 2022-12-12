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

namespace Krystof_20221212
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Soldier Mira;
        Soldier Pepa;
        public MainWindow()
        {
            InitializeComponent();
            Mira = new Soldier();
            Mira.Jmeno = "Player";
            Mira.Prijmeni = "1";
            Zobraz(Mira, txtBox1);

            Pepa = new Soldier();
            Pepa.Jmeno = "Player";
            Pepa.Prijmeni = "2";
            Zobraz(Pepa, txtBox2);
        }
        public void Zobraz(Soldier soldier, TextBox textBox)
        {
            textBox.Text = soldier.Jmeno + " " + soldier.Prijmeni + "\n";
            textBox.Text += "HP" + soldier.HP.ToString() + "\n";
            textBox.Text += "Shield" + soldier.Shield.ToString() + "\n";
            textBox.Text += "Level" + soldier.Level.ToString() + "\n";


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pepa.Attack();
            Zobraz(Pepa, txtBox2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mira.Attack();
            Zobraz(Mira, txtBox1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Mira.Heal();
            Zobraz(Mira, txtBox1);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Pepa.Heal();
            Zobraz(Pepa, txtBox2);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Pepa.SuperAttack();
            Zobraz(Pepa, txtBox2);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Mira.SuperAttack();
            Zobraz(Mira, txtBox1);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Mira.SuperHeal();
            Zobraz(Mira, txtBox1);
        }
    }
}

        
    

