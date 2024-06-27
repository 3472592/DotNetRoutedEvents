using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RoutedEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<string> outputItems = new();
        public MainWindow()
        {
            InitializeComponent();

            output.ItemsSource = outputItems;
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("The ellipse was pressed");
            if (ellipseSetsHandled.IsChecked == true) e.Handled = true;
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("The rectangle was pressed");
            if (rectangleSetsHandled.IsChecked == true) e.Handled = true;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("The grid was pressed");
            if (gridSetsHandled.IsChecked == true) e.Handled = true;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("The border was pressed");
            if (borderSetsHandled.IsChecked == true) e.Handled = true;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("The panel was pressed");
        }

        private void UpdateHitTestButton(object sender, RoutedEventArgs e)
        {
            #pragma warning disable CS8629 // Null able value type may be null.
            grayRectangle.IsHitTestVisible = (bool)newHitTestVisibleValue.IsChecked;
        }
    }
}
