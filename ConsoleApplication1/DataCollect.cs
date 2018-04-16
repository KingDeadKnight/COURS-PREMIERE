using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ConsoleApplication1
{
    class DataCollect
    {
        public int tbCountItems;

        public DataCollect()
        {
            using(var client = new WebClient())
            {
                Uri Url = new Uri("https://jsonplaceholder.typicode.com/posts");
                var resString = client.DownloadString(Url);
                var data = new JavaScriptSerializer().Deserialize<List<JsonTest>>(resString);
                //this.tbCountItems.Invoke((Action)(() =>
                //{
                //    data.Count.ToString();
                //});
            }
        }
    }

    class JsonTest
    {
        public string UserId { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public override string ToString() 
        {
            return UserId + " " + Id + " " + Title + " " + Body;
        }
    }
}
