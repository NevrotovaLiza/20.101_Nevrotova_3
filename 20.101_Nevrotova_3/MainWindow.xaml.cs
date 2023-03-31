using _20._101_Nevrotova_3.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace _20._101_Nevrotova_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Entities bd = new Entities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Discipline_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from discipline in bd.Discipline select new { discipline.IdDiscipline, discipline.Title};
            LoadData.ItemsSource = query.ToList();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(tb_Search.Text);
                var dRow = bd.Discipline.Where(w => w.IdDiscipline == num).FirstOrDefault();
                bd.SaveChanges();
                var query = from discipline in bd.Discipline select new { discipline.IdDiscipline, discipline.Title };
                LoadData.ItemsSource = query.ToList();

            }
            catch
            {
                MessageBox.Show("Результат поиска отсутствует");
            }
        }
    }
}
