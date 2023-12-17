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
    /// Логика взаимодействия для BudgetMenu.xaml
    /// </summary>
    public partial class BudgetMenu : Page
    {
        public BudgetMenu()
        {
            InitializeComponent();
        }

        private void BudgetButtonExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("MainMenu.xaml", UriKind.Relative));
        }

        private void BudgetPlannedIncomes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("PlannedIncomes.xaml", UriKind.Relative));
        }

        private void BudgetPlannedExpenses_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("PlannedExpenses.xaml", UriKind.Relative));
        }

        private void BudgetButtonNewBudget_Click(object sender, RoutedEventArgs e)
        {
            newBudgetSettings.Visibility = Visibility.Visible;
        }
    }
}
