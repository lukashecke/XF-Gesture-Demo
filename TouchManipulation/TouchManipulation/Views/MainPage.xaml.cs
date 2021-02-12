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
            LoadResourceBitmap();

            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }

        private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            canvas.DrawBitmap(resourceBitmap, new SKRect(0, info.Height / 3, info.Width, 2 * info.Height / 3));
        }

        private void OnTouchEffectAction(object sender, TouchActionEventArgs args)
        {
            // TODO LHE:
            Console.WriteLine("OnTouchEffectAction");
        }

        private void LoadResourceBitmap()
        {
            string resourceID = "TouchManipulation.Media.octocat-jedi.jpg";
            Assembly assembly = GetType().GetTypeInfo().Assembly;

            using (Stream stream = assembly.GetManifestResourceStream(resourceID))
            {
                resourceBitmap = SKBitmap.Decode(stream);
            }
        }
    }
}
