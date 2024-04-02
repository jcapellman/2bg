using Windows.UI;
using Windows.UI.Xaml.Controls;

using Microsoft.Graphics.Canvas.UI.Xaml;

namespace GaiaEterna.App.UWP
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
        }

        private void CcMain_Draw(CanvasControl sender, CanvasDrawEventArgs args)
        {
            args.DrawingSession.DrawText("Gaia Eterna", 100, 100, Colors.White);
        }
    }
}