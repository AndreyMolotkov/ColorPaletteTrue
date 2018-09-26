using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Media;
using System.Collections.ObjectModel;
namespace ColorPallete.ViewModel
{
    public class ColorTrajectory
    {
        public Color Color { get; set; }
        //public string Color { get; set; }
        public string Name { get; set; }
    }

    public class NewColor
    {
        public Color Color { get; set; }
        public int Position { get; set; }
    }
    //NEW CODE
    //NEWNEW CODE
    public class neww { }

    public class ViewModel
    { 
        public List<ColorTrajectory> MyItems { get; set; }
        public NewColor NewColor { get; set; }
        public ViewModel()
        {
            MyItems = new List<ColorTrajectory>();
            /*
            {
                //new ColorTrajectory{ Name = "Blue", Color = "Blue"},
                //new ColorTrajectory{ Name = "Green", Color = "Green"},
                //new ColorTrajectory{ Name = "Red", Color = "Red"}
                
                new ColorTrajectory{ Name="Blue1",Color=new Color(){ A = 255, B = 100, G = 0, R = 0} },
                new ColorTrajectory{ Name="Blue2",Color=new Color(){ A = 255, B = 150, G = 0, R = 0} },
                new ColorTrajectory{ Name="Blue3",Color=new Color(){ A = 255, B = 200, G = 0, R = 0} },
                new ColorTrajectory{ Name="Blue4",Color=new Color(){ A = 255, B = 250, G = 0, R = 0} },
                
                new ColorTrajectory{ Name="Green1",Color=new Color(){ A = 255, B = 0, G = 100, R = 0} },
                new ColorTrajectory{ Name="Green2",Color=new Color(){ A = 255, B = 0, G = 150, R = 0} },
                new ColorTrajectory{ Name="Green3",Color=new Color(){ A = 255, B = 0, G = 200, R = 0} },
                new ColorTrajectory{ Name="Green4",Color=new Color(){ A = 255, B = 0, G = 250, R = 0} },
                
                new ColorTrajectory{ Name="Red1",Color=new Color(){ A = 255, B = 0, G = 0, R = 100} },
                new ColorTrajectory{ Name="Red2",Color=new Color(){ A = 255, B = 0, G = 0, R = 150} },
                new ColorTrajectory{ Name="Red3",Color=new Color(){ A = 255, B = 0, G = 0, R = 200} },
                new ColorTrajectory{ Name="Red4",Color=new Color(){ A = 255, B = 0, G = 0, R = 250} }
            };
            */
            
            //MyItems = new List<ColorTrajectory>();
            MyItems.Add(new ColorTrajectory()
            {
                Color = new Color() { A = 255, B = 255, G = 0, R = 0 },
                Name = "Blue"
            });
            MyItems.Add(new ColorTrajectory()
            {
                Color = new Color() { A = 255, B = 0, G = 255, R = 0 },
                Name = "Green"
            });
            MyItems.Add(new ColorTrajectory()
            {
                Color = new Color() { A = 255, B = 0, G = 0, R = 255 },
                Name = "Red"
            });
            MyItems.Add(new ColorTrajectory()
            {
                Color = new Color() { A = 255, B = 255, G = 255, R = 255 },
                Name = "White"
            });

            //MyItems[2].Color = new Color() { A = 255, B = 255, G = 255, R = 255 };
        }

        public ViewModel(List<ColorTrajectory> ColorList)
        {
            MyItems = ColorList;
        }

        //private List<ColorTrajectory> _colorList;
        //public List<ColorTrajectory> ColorList
        // {
        //     get { return _colorList; }
        //     set { _colorList = value; }
        // }
    }
}