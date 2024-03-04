using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System;
using System.Diagnostics;


namespace DZ2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Button_Click(object? sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string buttonName = button.Name;
                FillRectangle(buttonName);
            }


        }
        private void FillRectangle(string buttonName)
        {
            var button = this.FindControl<Button>(buttonName);
            var rectangle = this.FindControl<Avalonia.Controls.Shapes.Rectangle>("ColorRectangle");
            var backgroundBrush = button.Background;

            if (backgroundBrush is ISolidColorBrush solidColorBrush)
            {
                var color = solidColorBrush.Color;
                rectangle.Fill = new SolidColorBrush(color);
            }
        }

    }
}