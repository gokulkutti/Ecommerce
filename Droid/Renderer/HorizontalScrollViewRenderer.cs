﻿using System;
using System.ComponentModel;
using Android.Content;
using Ecommerce;
using Ecommerce.Droid;
using Ecommerce.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(HorizontalScrollView), typeof(HorizontalScrollViewRenderer))]
namespace Ecommerce.Droid.Renderer
{
    public class HorizontalScrollViewRenderer : ScrollViewRenderer
    {
        

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var element = e.NewElement as HorizontalScrollView;
            element?.Render();

            if (e.OldElement != null || this.Element == null)
                return;

            if (e.OldElement != null)
                e.OldElement.PropertyChanged -= OnElementPropertyChanged;

            e.NewElement.PropertyChanged += OnElementPropertyChanged;
        }

        protected void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
            if (ChildCount > 0)
            {
                GetChildAt(0).HorizontalScrollBarEnabled = false;
                GetChildAt(0).VerticalScrollBarEnabled = false;
            }
        }
    }
}
