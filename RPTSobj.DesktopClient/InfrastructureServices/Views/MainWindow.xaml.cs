using RPTSobj.DesktopClient.InfrastructureServices.ViewModels;
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
using System.Net;
using Newtonsoft.Json;
using RPTSobj.InfrastructureServices.Gateways.Database;
using RPTSobj.WebService.InfrastructureServices.Gateways;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Data.Sqlite;


namespace RPTSobj.DesktopClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Name = "btn1";
            btn.Click += btn1_Click;
            DataContext = viewModel;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string result = client.DownloadString("https://apidata.mos.ru/v1/datasets/2624/rows?api_key=b830358d40b1d55aa8d34b4f33b5f6c6");
            List<ResultFromServer> resultServer = JsonConvert.DeserializeObject<List<ResultFromServer>>(result);
            var optionsBuilder = new DbContextOptionsBuilder<RPTSobjContext>();
            string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\"));
            string newnewpath = System.IO.Path.Combine(newPath, "InnovativeProduct.WebService", "InnovativeProduct.db");
            optionsBuilder.UseSqlite($"Data Source={newnewpath}");
            var context = new RPTSobjContext(options: optionsBuilder.Options);
            context.Database.ExecuteSqlRaw("DELETE FROM RPTSobj");
            using (context)
            {
                foreach (var item in resultServer)
                {
                    DomainObjects.rptsobj rptsobj = new DomainObjects.rptsobj();
                    rptsobj.Name = item.Cells.Name;
                    rptsobj.Address = item.Cells.Address;
                    rptsobj.MetroStation = item.Cells.MetroStation;
                    rptsobj.MetroLine = item.Cells.MetroLine;
                    rptsobj.WebSite = item.Cells.WebSite;
                    context.Entry(rptsobj).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
        }
    }
}