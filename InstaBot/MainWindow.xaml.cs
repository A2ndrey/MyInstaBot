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


namespace InstaBot
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitialForm();
        }

        private void InitialForm()
        {
            SourceP.Text = @"E:\Browser_Downloads\bmw\used";
            DestinyP.Text = @"E:\Browser_Downloads\bmw\tmp";
            InstName1.Text = "vasylko.kuznetc";
            InstName2.Text = "i2va22020";
            InstPass1.Text = "qwpogh1290_153";
            InstPass2.Text = "polo12378";
            Count.Text = "5";
        }
         
 
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            MyPost post = new MyPost(SourceP.Text,DestinyP.Text,InstName1.Text,InstPass1.Text,Count.Text);

            if (post.CopyFilesIntoAccont())
                System.Windows.MessageBox.Show("Succes","Information");

            // Application.Current.Shutdown();
            //   var direct = Directory.GetFiles()
        }

        private void SourcePath_Click(object sender, RoutedEventArgs e)
        {
            
        }

 
    private void DestinyPath_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
