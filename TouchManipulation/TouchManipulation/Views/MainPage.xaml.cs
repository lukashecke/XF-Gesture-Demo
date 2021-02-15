using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using TouchManipulation.TouchTracking;
using TouchManipulation.ViewModels;
using Xamarin.Forms;

namespace TouchManipulation.Views
{
    public partial class MainPage : ContentPage
    {
        SKBitmap resourceBitmap;

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }

        private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();
        }

        private void OnTouchEffectAction(object sender, TouchActionEventArgs args)
        {
            // TODO LHE: https://docs.microsoft.com/de-de/xamarin/xamarin-forms/user-interface/graphics/skiasharp/transforms/touch#pinching-and-scaling
            Console.WriteLine("OnTouchEffectAction");
        }
    }
}
