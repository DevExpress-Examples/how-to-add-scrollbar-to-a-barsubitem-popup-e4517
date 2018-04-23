using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DXSample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    public class StringsSource : System.Windows.Markup.MarkupExtension {
        public StringsSource() { }
        int count = 0;
        public StringsSource(int count) {
            this.count = count;
        }
        public override object ProvideValue(IServiceProvider serviceProvider) {
            List<String> list = new List<string>();
            for(int i = 0; i < count; i++)
                list.Add("item " + i);
            return list;
        }
    }
}
