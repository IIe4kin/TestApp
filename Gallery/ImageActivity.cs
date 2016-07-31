using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Gallery
{
    [Activity(Label = "ImageActivity")]
    public class ImageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Imagelayout);
            // Create your application here

            var imview = FindViewById<ImageView>(Resource.Id.imageView1);
            

            int position = Intent.Extras.GetInt("id");
            ImageAdapter imageAdapter = new ImageAdapter(this);
            imview.SetImageResource(imageAdapter.thumbIds[position]);
            
        }
    }
}