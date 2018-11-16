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
    public class CommentAdapter : BaseAdapter<CommentItems>
    {

        public List<CommentItems> coms;
        Activity context;

        public CommentAdapter(Activity context, List<CommentItems> items)
        {
            this.context = context;
            this.coms = items;
        }



        public override CommentItems this[int position]
        {
            get { return coms[position]; }
        }



        public override int Count { get { return coms.Count; } }



        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.commentpreset, null);
            view.FindViewById<TextView>(Resource.Id.textView1).Text = coms[position].ComName;
            view.FindViewById<TextView>(Resource.Id.textView2).Text = coms[position].Comment;


            return view;
        }
    }
}