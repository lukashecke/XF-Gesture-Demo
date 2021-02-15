using System;
using TouchManipulation.TouchTracking;
using TouchManipulation.ViewModels;
using Xamarin.Forms;

namespace TouchManipulation.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }

        private void OnTouchEffectAction(object sender, TouchActionEventArgs args)
        {
            // TODO LHE: https://docs.microsoft.com/de-de/xamarin/xamarin-forms/user-interface/graphics/skiasharp/transforms/touch#pinching-and-scaling
            Console.WriteLine("OnTouchEffectAction");
            Log(args.Type.ToString());
            Log(args.Location.ToString());
        }

        private void Log(string text)
        {
            ((MainPageViewModel)this.BindingContext).TouchLog += Environment.NewLine + text;
            ScrollToEnd();
        }

        private void ScrollToEnd()
        {
            if (PART_ScrollView.ContentSize.Height > PART_ScrollView.Height)
            {
                double spaceBetweenLinesOnALabel = 5;
                double scrollPositionY = PART_ScrollView.ContentSize.Height - PART_ScrollView.Height +
                                         (((Label)PART_ScrollView.Content).FontSize*2) + spaceBetweenLinesOnALabel;
                PART_ScrollView.ScrollToAsync(0, scrollPositionY, true);
            }
        }
    }
}
