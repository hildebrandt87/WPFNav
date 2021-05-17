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

namespace WPFNavi
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Info für mich:
        //Die Datenstruktur wird in einer XML abgebildet
        //Das hat den vorteil die XML wir einmal eingelesen und einmal geladen.
        //Bei einem Wechsel der Buttons kann die XML struktur genommen werden

        //Untere Notes bekommen noch die Eigenschaften:
        //Alarmvariable
        //Name 
        //Funktion die ausgeführt wird

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 100; ++i)
            {
                Button button = new Button()
                {
                    Content = string.Format("Button for {0}", i),
                    Tag = i
                };
                button.Margin = new Thickness(20, 0, 0, 0);
                button.Click += new RoutedEventHandler(button_Click);
                this.stack.Children.Add(button);
            }
            //scrollview.Content = stack;
        }
        void button_Click(object sender, RoutedEventArgs e)
        {
          
            var btn = (sender as Button).Tag;

            if(Convert.ToInt32(btn) == 0)
            {
                stack.Children.Clear();
                for (int i = 0; i < 3; ++i)
                {
                    Button button = new Button()
                    {
                        Content = string.Format("SubButton for {0}", i),
                        Tag = i
                    };
                    button.Margin = new Thickness(20, 0, 0, 0);
                    button.Click += new RoutedEventHandler(button_Click);
                    this.stack.Children.Add(button);
                }
            }

            if (Convert.ToInt32(btn) == 1)
            {
                stack.Children.Clear();
                for (int i = 0; i < 100; ++i)
                {
                    Button button = new Button()
                    {
                        Content = string.Format("SubButton for {0}", i),
                        Tag = i
                    };
                    button.Margin = new Thickness(20, 0, 0, 0);
                    button.Click += new RoutedEventHandler(button_Click);
                    this.stack.Children.Add(button);
                }
            }

        }
    }
}
