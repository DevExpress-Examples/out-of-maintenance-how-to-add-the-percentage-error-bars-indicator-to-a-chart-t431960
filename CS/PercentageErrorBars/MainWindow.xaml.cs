using System.Collections.Generic;
using System.Windows;

namespace ErrorBars {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
}
//        List<DataItem> GetData() {
//            return new List<DataItem>() {
//                new DataItem("A", 20),
//                new DataItem("B", 50),
//                new DataItem("C", 40),
//                new DataItem("D", 22),
//                new DataItem("E", 30),
//                new DataItem("F", 45),
//                new DataItem("G", 35),
//                new DataItem("H", 28),
//                new DataItem("I", 46),
//                new DataItem("J", 27),
//                new DataItem("K", 20),
//                new DataItem("L", 50),
//                new DataItem("M", 40),
//                new DataItem("N", 22),
//                new DataItem("O", 30),
//                new DataItem("P", 45),
//                new DataItem("Q", 35),
//            };
//        }
//        private void OnLoaded(object sender, RoutedEventArgs e) {
//            if (pointSeries != null) {
//                pointSeries.ArgumentDataMember = "Argument";
//                pointSeries.ValueDataMember = "Value";
//                pointSeries.DataSource = GetData();
//            }
//        }
//    }
//    public class DataItem {
//        public string Argument { get; private set; }
//        public int Value { get; private set; }
//        public DataItem(string argument, int value) {
//            Argument = argument;
//            Value = value;
//        }
//    }
//}
