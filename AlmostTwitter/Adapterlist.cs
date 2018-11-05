using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Media;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AlmostTwitter
{
    public class Adapterlist : BaseAdapter<Holder>
    {
        public List<Holder> holders;

        Activity context;

        public Adapterlist(Activity context, List<Holder> items)
        {
            this.context = context;
            this.holders = items;
        }
        
        

        public override Holder this[int position]
        {
            get { return holders[position]; }
        }

       

        public override int Count { get { return holders.Count; } }

        

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.activity_main, null);

            view.FindViewById<TextView>(Resource.Id.Nametext).Text = holders[position].Name;
            view.FindViewById<TextView>(Resource.Id.datetext).Text = holders[position].Date;
            view.FindViewById<TextView>(Resource.Id.messagetext).Text = holders[position].Message;
            int ideksdee = (int)typeof(Resource.Drawable).GetField(holders[position].itbe).GetValue(null);
            view.FindViewById<ImageView>(Resource.Id.Profpic).SetImageResource(ideksdee);

            return view;
        }
    }
}