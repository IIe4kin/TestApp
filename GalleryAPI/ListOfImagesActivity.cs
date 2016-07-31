using System;
using System.Collections.Generic;
using System.IO;
using System.Json;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GalleryAPI.Models;

namespace GalleryAPI
{
    [Activity(Label = "ListOfImagesActivity")]
    public class ListOfImagesActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            List<string> items = new List<string>() { };
            List<ImageModel> listOfImages = new List<ImageModel>()
        {
            new ImageModel {id = 0, title = "sky" }
        };

            base.OnCreate(savedInstanceState);



            foreach (ImageModel im in listOfImages)
            {
                items.Add("Image: id = " + im.id.ToString() + ", title = " + im.title);
            }

            ListAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, items.ToArray());

            // Create your application here
        }

        //protected override void OnListItemClick(ListView l, View v, int position, long id)
        //{
        //    //var t = items[position];
        //    Toast.MakeText(this, t, ToastLength.Short).Show();
        //}

        
    }
}