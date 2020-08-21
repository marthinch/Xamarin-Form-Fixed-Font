using System;
using Android.Content;
using Android.Graphics;
using FixFontSize.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Label), typeof(MyLabelRender))]
namespace FixFontSize.Droid.Renders
{
    public class MyLabelRender : LabelRenderer
    {
        public MyLabelRender(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
                return;

            if (Control != null)
            {
                // This will adjust from tag font size
                //Control.SetTextSize(Android.Util.ComplexUnitType.Dip, (float)e.NewElement.FontSize);

                // This is fix size
                Control.SetTextSize(Android.Util.ComplexUnitType.Dip, (float)12.0);

                // This will set font family & font attribute
                Control.SetTypeface(Typeface.SansSerif, TypefaceStyle.Bold);
            }
        }
    }
}