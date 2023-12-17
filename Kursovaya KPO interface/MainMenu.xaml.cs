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

namespace Kursovaya_KPO_interface
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonExitToStartMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("StartMenu.xaml", UriKind.Relative));
        }

        private void ButtonIncomes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Incomes.xaml", UriKind.Relative));
        }

        private void ButtonExpenses_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Expenses.xaml", UriKind.Relative));
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void ButtonBudgets_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("BudgetMenu.xaml", UriKind.Relative));
        }
    }

}
