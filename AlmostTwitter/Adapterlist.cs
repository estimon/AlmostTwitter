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
    public class Adapterlist : BaseAdapter<PostItems>
    {
        public List<PostItems> items;

        Activity context;

        public Adapterlist(Activity context, List<PostItems> items)
        {
            this.context = context;
            this.items = items;
        }



        public override PostItems this[int position]
        {
            get { return items[position]; }
        }



        public override int Count { get { return items.Count; } }



        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.activity_main, null);

            view.FindViewById<TextView>(Resource.Id.Nametext).Text = items[position].Name;
            view.FindViewById<TextView>(Resource.Id.datetext).Text = items[position].Date;
            view.FindViewById<TextView>(Resource.Id.messagetext).Text = items[position].Message;
            int img = (int)typeof(Resource.Drawable).GetField(items[position].ProfilePic).GetValue(null);
            view.FindViewById<ImageView>(Resource.Id.Profpic).SetImageResource(img);
            view.FindViewById<TextView>(Resource.Id.textView1).Text = items[position].Like.ToString();



            var clickLikeButton = view.FindViewById<Button>(Resource.Id.button1);
            clickLikeButton.Tag = position;
            clickLikeButton.Click -= Button_Click;
            clickLikeButton.Click += Button_Click;

            var combutton = view.FindViewById<Button>(Resource.Id.button2);
            combutton.Click += Button_Click1;
            combutton.Tag = position;


            return view;
        }
        void Button_Click(object sender, EventArgs e)
        {
            var LikeButton = (Button)sender;
            int position = (int)LikeButton.Tag;

            items[position].Like++;
            NotifyDataSetChanged();


        }


        void Button_Click1(object sender, EventArgs e)
        {
            var commbtn = (Button)sender;
            int position = (int)commbtn.Tag;
            Things.comments = items[position].PostComment;
            context.StartActivity(typeof(commentactivity));

        }


    }
}