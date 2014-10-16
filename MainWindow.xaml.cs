using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MenuRound
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public BitmapImage SetImageSource(string iconImgURL)
        {
            BitmapImage bitimg = new BitmapImage();
            bitimg.BeginInit();
            var uriSource = new Uri(@"/icon/" + iconImgURL, UriKind.Relative);
            bitimg.UriSource = uriSource;
            bitimg.EndInit();
            return bitimg;
        }
      

        public MainWindow()
        {
            InitializeComponent();
            int iconWidthAndHeight = 50;
            //添加第一个按钮
            Image imgtop = new Image();
            imgtop.Source = SetImageSource("2购物搜索.png");
            imgtop.Width = imgtop.Height = iconWidthAndHeight;
            imgtop.SetValue(Canvas.LeftProperty, MenuCanvas.Width / 2 - iconWidthAndHeight / 2);
            imgtop.SetValue(Canvas.TopProperty, 0.0);
            MenuCanvas.Children.Add(imgtop);

            //内圆直径
            double NeiYuanZhiJing = (MenuCanvas.Width / 2 - iconWidthAndHeight / 2);
            //30度角对应边长
            double temp30 = NeiYuanZhiJing / 2;
            //60度角对应边长
            double temp60 = Math.Sqrt(3) * temp30;

            //左上角按钮
            Image imgleft1 = new Image();
            imgleft1.Source = SetImageSource("3安全购物.png");
            imgleft1.Width = imgleft1.Height = iconWidthAndHeight;
            imgleft1.SetValue(Canvas.LeftProperty, MenuCanvas.Width / 2 - temp60 - iconWidthAndHeight / 2);
            imgleft1.SetValue(Canvas.TopProperty, MenuCanvas.Width / 2 - temp30 - iconWidthAndHeight / 2);
            MenuCanvas.Children.Add(imgleft1);

            //左下角按钮
            Image imgleft2 = new Image();
            imgleft2.Source = SetImageSource("4桌面提醒.png");
            imgleft2.Width = imgleft2.Height = iconWidthAndHeight;
            imgleft2.SetValue(Canvas.LeftProperty, MenuCanvas.Width / 2 - temp60 - iconWidthAndHeight / 2);
            imgleft2.SetValue(Canvas.TopProperty, MenuCanvas.Width / 2 + temp30 - iconWidthAndHeight / 2);
            MenuCanvas.Children.Add(imgleft2);

          
            //底部按钮
            Image imgbottom = new Image();
            imgbottom.Source = SetImageSource("5信誉交友.png");
            imgbottom.Width = imgbottom.Height = iconWidthAndHeight;
            imgbottom.SetValue(Canvas.LeftProperty, MenuCanvas.Width / 2 - iconWidthAndHeight / 2);
            imgbottom.SetValue(Canvas.TopProperty, MenuCanvas.Width - iconWidthAndHeight);
            MenuCanvas.Children.Add(imgbottom);

            //右上角按钮
            Image imgright1 = new Image();
            imgright1.Source = SetImageSource("6购物记事本.png");
            imgright1.Width = imgbottom.Height = iconWidthAndHeight;
            imgright1.SetValue(Canvas.RightProperty, MenuCanvas.Width / 2 - temp60 - iconWidthAndHeight / 2);
            imgright1.SetValue(Canvas.TopProperty, MenuCanvas.Width / 2 - temp30 - iconWidthAndHeight / 2);
            MenuCanvas.Children.Add(imgright1);
            //右下角按钮
            Image imgright2 = new Image();
            imgright2.Source = SetImageSource("7设置.png");
            imgright2.Width = imgbottom.Height = iconWidthAndHeight;
            imgright2.SetValue(Canvas.RightProperty, MenuCanvas.Width / 2 - temp60 - iconWidthAndHeight / 2);
            imgright2.SetValue(Canvas.TopProperty, MenuCanvas.Width / 2 + temp30 - iconWidthAndHeight / 2);
            MenuCanvas.Children.Add(imgright2);
           



        }
    }
}
