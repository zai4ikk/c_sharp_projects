using System;
using System.Collections.Generic;
using System.IO;
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

namespace ToursApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new HotelsPage());
            Manager.MainFrame=MainFrame;

            ImportTours();
        }

        private void ImportTours()
        {
            var filedata = File.ReadAllLines("Z:\\МДК 01.02\\Tours\\Resources\\Туры.txt");
            var images = Directory.GetFiles("Z:\\МДК 01.02\\Tours\\ToursApp\\Resources\\img\\k.jpg");

            foreach (var line in filedata)
            {
                var data = line.Split('\t');

                var tempTour = new Tour
                {
                    Name = data[0].Replace("\"", ""),
                    TicketCourt = int.Parse(data[2]),
                    Price = decimal.Parse(data[3]),
                    IsActual = (data[4] == "0") ? false : true
                };
                foreach (var tourType in data[5].Split(new string[] { ","}, StringSplitOptions.RemoveEmptyEntries))
                {
                    var currentType = ToursEntities.GetContext().Type.ToList().FirstOrDefault(p => p.Name == tourType);
                    if (currentType != null)
                    {
                        tempTour.Type.Add(currentType);
                    }
                }

                try
                {
                    tempTour.ImagePreview = File.ReadAllBytes(images.FirstOrDefault(p=>p.Contains(tempTour.Name)));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                ToursEntities.GetContext().Tour.Add(tempTour);
                ToursEntities.GetContext().SaveChanges();
            }
        }










        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack) {
                BtnBack.Visibility = Visibility.Visible;           
            }
            else { BtnBack.Visibility = Visibility.Hidden; }
        }
    }
}
