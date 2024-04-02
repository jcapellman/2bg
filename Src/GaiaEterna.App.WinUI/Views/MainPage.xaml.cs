using GaiaEterna.App.WinUI.ViewModels;
using Microsoft.Graphics.Canvas.UI.Xaml;
using Microsoft.UI;
using Microsoft.UI.Xaml.Controls;

namespace GaiaEterna.App.WinUI.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    void canvasControl_Draw(CanvasControl sender, CanvasDrawEventArgs args)
    {
        args.DrawingSession.DrawText("Gaia Eterna", 100, 100, Colors.White);
    }
}
