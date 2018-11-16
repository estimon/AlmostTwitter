using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using System.Collections.Generic;
using Android.Content;

namespace AlmostTwitter
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public List<PostItems> listholder;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.list);

            var list1 = FindViewById<ListView>(Resource.Id.listView1);
            var likebtn = FindViewById<Button>(Resource.Id.button1);
            var commentbtn = FindViewById<Button>(Resource.Id.button2);

            

            listholder = new List<PostItems>();
            
            PostItems Elon = new PostItems
            {
                Name = "Elon Musk",
                Date = DateTime.Today.ToString(),
                Message = "I'm Elon Musk",
                ProfilePic = "Elon_Musk_2015",

                PostComment = new List<CommentItems>
                {
                    new CommentItems
                    {
                        ComName = "Ben Shapiro",
                        Comment = "YES"
                    }
                }
            };
            listholder.Add(Elon);


            PostItems Trupm = new PostItems
            {
                Name = "Trump",
                Date = DateTime.Today.ToString(),
                Message = "Thank you Kanye very cool",
                ProfilePic = "kUuht00m_400x400",

                PostComment = new List<CommentItems>
                {
                    new CommentItems
                    {
                        ComName = "Kanye",
                        Comment = "My phone password is 0000"
                    }
                }


            };
            
            listholder.Add(Trupm);

            PostItems WisePerson= new PostItems
            {
                Name = "Wise person",
                Date = DateTime.Today.ToString(),
                Message = "It be like that sometimes",
                ProfilePic = "Capture",

                PostComment = new List<CommentItems>
                {
                    new CommentItems
                    {
                        ComName = "Wise person number 2",
                        Comment = "it do"
                    }
                }
            };
            listholder.Add(WisePerson);


            list1.Adapter = new Adapterlist(this, listholder);

            var AddNewPost = FindViewById<Button>(Resource.Id.addnewpostbtn);
            AddNewPost.Click += Button_Click;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            
            var listView = FindViewById<ListView>(Resource.Id.listView1);
            string Addpost = FindViewById<EditText>(Resource.Id.textInputEditText1).Text;
            PostItems User = new PostItems
            {
                Name = "User",
                Date = DateTime.Today.ToString(),
                Message = Addpost,
                ProfilePic = "MIN_172701_SWA",

                PostComment = new List<CommentItems>()
               
            };

            listholder.Add(User);
            listView.Adapter = new Adapterlist(this, listholder);

           
        }



    }
}