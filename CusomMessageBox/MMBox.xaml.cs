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
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;

namespace CusomMessageBox
{
    public partial class MMBox : Window
    {
        public MMBox()
        {
            InitializeComponent();
        }

        private MessageBoxResult defaultResult;
        private bool defaultExist = false;

        internal void setButtons(MessageBoxButton button)
        {
            PackIcon[] icons = new PackIcon[3];
            icons[0] = new PackIcon();
            icons[0].Kind = PackIconKind.Check;

            icons[1] = new PackIcon();
            icons[1].Kind = PackIconKind.DeleteForever;

            icons[2] = new PackIcon();
            icons[2].Kind = PackIconKind.Close;

            switch (button)
            {
                case MessageBoxButton.OK:

                    button0.Tag = "OK";
                    button0.Content = icons[0];
                    button0.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00A416"));

                    button1.Visibility = Visibility.Hidden;

                    button2.Visibility = Visibility.Hidden;

                    break;

                case MessageBoxButton.OKCancel:

                    button0.Tag = "OK";
                    button0.Content = icons[0];
                    button0.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00A416"));

                    button1.Tag = "Cancel";
                    button1.Content = icons[1];
                    button1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF304FFE"));

                    button2.Visibility = Visibility.Hidden;

                    break;

                case MessageBoxButton.YesNo:

                    button0.Tag = "No";
                    button0.Content = icons[2];
                    button0.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF0000"));

                    button1.Tag = "Yes";
                    button1.Content = icons[0];
                    button1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00A416"));

                    button2.Visibility = Visibility.Hidden;

                    break;

                case MessageBoxButton.YesNoCancel:

                    button0.Tag = "No";
                    button0.Content = icons[2];
                    button0.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF0000"));

                    button1.Tag = "Yes";
                    button1.Content = icons[0];
                    button1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00A416"));

                    button2.Tag = "Cancel";
                    button2.Content = icons[1];
                    button2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF304FFE"));

                    break;
            }
        }

        internal void setNoneButtons()
        {
            button0.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            BoxIcon.Visibility = Visibility.Hidden;
        }
        internal void setButtons(MessageBoxButton button, MessageBoxResult defaultresult)
        {
            defaultExist = true;
            defaultResult = defaultresult;

            PackIcon[] icons = new PackIcon[3];
            icons[0] = new PackIcon();
            icons[0].Kind = PackIconKind.Check;

            icons[1] = new PackIcon();
            icons[1].Kind = PackIconKind.DeleteForever;

            icons[2] = new PackIcon();
            icons[2].Kind = PackIconKind.Close;

            switch (button)
            {
                case MessageBoxButton.OK:

                    button0.Tag = "OK";
                    button0.Content = icons[0];
                    button0.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00A416"));

                    button1.Visibility = Visibility.Hidden;

                    button2.Visibility = Visibility.Hidden;

                    break;
                case MessageBoxButton.OKCancel:

                    button0.Tag = "OK";
                    button0.Content = icons[0];
                    button0.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00A416"));

                    button1.Tag = "Cancel";
                    button1.Content = icons[1];
                    button1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF304FFE"));

                    button2.Visibility = Visibility.Hidden;

                    break;
                case MessageBoxButton.YesNo:

                    button0.Tag = "No";
                    button0.Content = icons[2];
                    button0.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF0000"));

                    button1.Tag = "Yes";
                    button1.Content = icons[0];
                    button1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00A416"));

                    button2.Visibility = Visibility.Hidden;

                    break;
                case MessageBoxButton.YesNoCancel:

                    button0.Tag = "No";
                    button0.Content = icons[2];
                    button0.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF0000"));

                    button1.Tag = "Yes";
                    button1.Content = icons[0];
                    button1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00A416"));

                    button2.Tag = "Cancel";
                    button2.Content = icons[1];
                    button2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF304FFE"));

                    break;
                default:
                    button0.Visibility = Visibility.Hidden;
                    button1.Visibility = Visibility.Hidden;
                    button2.Visibility = Visibility.Hidden;
                    BoxIcon.Visibility = Visibility.Hidden;
                    break;
            }
        }

        internal void setIcon(MessageBoxImage image)
        {
            switch (image)
            {
                case MessageBoxImage.Error:
                    BoxIcon.Kind = PackIconKind.Error;
                    BoxIcon.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF0000"));
                    break;
                case MessageBoxImage.Information:
                    BoxIcon.Kind = PackIconKind.InfoCircle;
                    BoxIcon.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF304FFE"));
                    break;
                case MessageBoxImage.Question:
                    BoxIcon.Kind = PackIconKind.QuestionMarkRhombus;
                    BoxIcon.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF304FFE"));
                    break;
                case MessageBoxImage.Warning:
                    BoxIcon.Kind = PackIconKind.WarningBox;
                    BoxIcon.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFB900"));
                    break;
                case MessageBoxImage.None:
                    BoxIcon.Kind = PackIconKind.None;
                    break;
            }
        }

        internal void setresult(object sender, RoutedEventArgs e)
        {
            defaultExist = false;
            MaterialMessageBox.result = stringToResult(((Button)sender).Tag.ToString());
            this.Close();
        }

        internal MessageBoxResult stringToResult(string value)
        {
            value = value.ToUpper();
            switch (value)
            {
                case "OK":
                    return MessageBoxResult.OK;

                case "CANCEL":
                    return MessageBoxResult.Cancel;

                case "YES":
                    return MessageBoxResult.Yes;

                case "NO":
                    return MessageBoxResult.No;

                default:
                    return MessageBoxResult.None;
            }
        }

        private void setDefault(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (defaultExist)
            {
                MaterialMessageBox.result = defaultResult;
            }
        }
    }
}
