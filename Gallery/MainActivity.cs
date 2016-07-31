using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;

namespace Gallery
{
    [Activity(Label = "Gallery", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var gridview = FindViewById<GridView>(Resource.Id.gridView1);
            gridview.Adapter = new ImageAdapter(this);

            gridview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args) 
            {
                Intent intent = new Intent(this, typeof(ImageActivity));
                intent.PutExtra("id",args.Position);
                StartActivity(intent); 
            };

        }        


    }
}


