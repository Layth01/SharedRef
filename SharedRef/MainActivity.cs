using Android.App;
using Android.Widget;
using Android.OS;
using Newtonsoft.Json.Linq;
using System;
using Android.Content;
using Android.Runtime;
using Android.Views;


namespace SharedRef
{
    [Activity(Label = "SharedRef", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);

            var textView1 = FindViewById<TextView>(Resource.Id.textView1);
            string json = "{name:'Layth CHEBBI', Jobs:['Developper','Tester','Admin'], Age:20}";
             var mydata = JObject.Parse(json);
            string name = mydata["name"].ToString();
            var Job = mydata["Jobs"];
            string FirstJob = Job[0].ToString();
            int age = Convert.ToInt32(mydata["Age"].ToString());

            textView1.Text = "Name : " + name + " Job : " + FirstJob + " Age : " + age;
        }
       
    }
}

