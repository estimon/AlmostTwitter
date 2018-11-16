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
    public class commentactivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.commentlist);

            var commentlist = FindViewById<ListView>(Resource.Id.commlist1);
            commentlist.Adapter = new CommentAdapter(this, Things.comments);
          
        }
    }
}