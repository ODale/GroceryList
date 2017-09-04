using Android.App;
using Android.OS;
using Android.Widget;

namespace GroceryList
{
	[Activity(Label = "Details")]			
	public class DetailsActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Details);

			int position = 0;

            //retrieve the position of the item selected in the list view
            //passed from the previous Activity using the ItemPosition key
            //function also takes a default value that is returned if the value pair is not found
            position = Intent.GetIntExtra("ItemPosition", -1);

			var item = MainActivity.Items[position];

			FindViewById<TextView>(Resource.Id.nameTextView ).Text = "Name: "  + item.Name;
			FindViewById<TextView>(Resource.Id.countTextView).Text = "Count: " + item.Count.ToString();
		}
	}
}