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
using System.Windows.Shapes;
using ColorPallete;

namespace WpfAppColor
{
    
    public partial class taskWindow : Window
    {
        public string ViewModel { get; set; }

        public taskWindow(int index)
        {
            InitializeComponent();
            int ColumnIndex = index;
            
        }

        private void canvas_SelectedColorChanged(object sender, EventArgs e)
        {
            //canvas.SelectedColor = canvas.SelectedColor;
            //Owner.DataContext = new SolidColorBrush((Color)canvas.SelectedColor);
            Block1.Background = new SolidColorBrush((Color)canvass.SelectedColor);
            

            ColorPallete.ViewModel.ViewModel OldViewModel = (ColorPallete.ViewModel.ViewModel)Owner.DataContext;
            List<ColorPallete.ViewModel.ColorTrajectory> NewColorList = OldViewModel.MyItems;
            MainWindow MyWindow = (MainWindow)Owner;
            NewColorList[MyWindow.dataGrid1.SelectedIndex].Color = (Color)canvass.SelectedColor;
            ColorPallete.ViewModel.ViewModel NewViewContext = new ColorPallete.ViewModel.ViewModel(NewColorList);
            Owner.DataContext = null;
            Owner.DataContext = NewViewContext;
            
            
            //Owner.Background = new SolidColorBrush((Color)canvass.SelectedColor);
            //Owner.Content= new SolidColorBrush((Color)canvass.SelectedColor);
            ///DataGrid.BackgroundProperty = new SolidColorBrush((Color)canvass.SelectedColor);
            //this.DataContext = new ViewModel.ViewModel();
            
        }
    }
}
