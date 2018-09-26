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
using ColorPallete.ViewModel;
using WpfAppColor;

namespace ColorPallete
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<ColorTrajectory> ColorList = new List<ColorTrajectory>()
            

            {
                //new ColorTrajectory{ Name = "Blue", Color = "Blue"},
                //new ColorTrajectory{ Name = "Green", Color = "Green"},
                //new ColorTrajectory{ Name = "Red", Color = "Red"}
                
                
                new ColorTrajectory{ Name="Color1",Color=new Color(){ A = 255, B = 100, G = 0, R = 0} },
                new ColorTrajectory{ Name="Color2",Color=new Color(){ A = 255, B = 150, G = 0, R = 0} },
                new ColorTrajectory{ Name="Color3",Color=new Color(){ A = 255, B = 200, G = 0, R = 0} },
                new ColorTrajectory{ Name="Color4",Color=new Color(){ A = 255, B = 250, G = 0, R = 0} },
                
                new ColorTrajectory{ Name="Color5",Color=new Color(){ A = 255, B = 0, G = 100, R = 0} },
                new ColorTrajectory{ Name="Color6",Color=new Color(){ A = 255, B = 0, G = 150, R = 0} },
                new ColorTrajectory{ Name="Color7",Color=new Color(){ A = 255, B = 0, G = 200, R = 0} },
                new ColorTrajectory{ Name="Color8",Color=new Color(){ A = 255, B = 0, G = 250, R = 0} },
                
                new ColorTrajectory{ Name="Color9",Color=new Color(){ A = 255, B = 0, G = 0, R = 100} },
                new ColorTrajectory{ Name="Color10",Color=new Color(){ A = 255, B = 0, G = 0, R = 150} },
                new ColorTrajectory{ Name="Color11",Color=new Color(){ A = 255, B = 0, G = 0, R = 200} },
                new ColorTrajectory{ Name="Color12",Color=new Color(){ A = 255, B = 0, G = 0, R = 250} }
            };

            ColorPallete.ViewModel.ViewModel ViewContext = new ViewModel.ViewModel(ColorList);
            this.DataContext = ViewContext;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int index = this.dataGrid1.SelectedIndex;
            taskWindow taskWindow = new taskWindow();
            taskWindow.Owner = this;
            taskWindow.Show();
            
  
        }
    }



}