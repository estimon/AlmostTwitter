using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AlmostTwitter
{
    [Activity(Label = "comac")]
    public class comac : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.commentlist);

            var comlistholder = new List<comments>();


            comments Jeff = new comments
            {
                ComName = "Jeff",
                Comment = "Very nice"
            };
          
        }
    }
}