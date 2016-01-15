using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CRMNexmo.Plugins
{
    public class SmsSender
    {
        /// <summary>
        /// Send SMS using Nexmo api
        /// </summary>
        /// <param name="number">to number</param>
        /// <param name="from">from number</param>
        /// <param name="username">username of nexmo</param>
        /// <param name="pasword">password of nexmo</param>
        /// <param name="text">text message</param>
        /// <returns>json result of sent message</returns>
        public string SendSMS(string to, string from, string username, string pasword, string text)
        {
            string uri = string.Format("http://rest.nexmo.com/sms/json?api_key={0}&api_secret={1}&from={2}&to={3}&text={4}", username, pasword, from, to, text);
            var json = new WebClient().DownloadString(uri);
            return json;
        }
        /// <summary>
        /// Get first number in the registered Number (Nexmo number)
        /// </summary>
        /// <param name="apikey">Nexmo API Key</param>
        /// <param name="secretkey">Nexmo Secret Key</param>
        /// <returns></returns>
        public string GetAccountNumber(string apikey, string secretkey)
        {
            string fromNumber = string.Empty;
            string uri = string.Format("http://rest.nexmo.com/account/numbers/{0}/{1}", apikey, secretkey);
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Method = "GET";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            string result = string.Empty;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                result = reader.ReadToEnd();
            }
            var jss = new JavaScriptSerializer();
            var dict = jss.Deserialize<RootObject>(result);
            if (dict.numbers.Count > 0)
            {
                fromNumber = dict.numbers[0].msisdn;
            }
            return fromNumber;
        }
        /// <summary>
        /// Validate nexmo credential
        /// </summary>
        /// <param name="apikey">Nexmo API Key</param>
        /// <param name="secretkey">Nexmo Secret Key</param>
        /// <returns>true or false</returns>
        public bool ValidateNexmoCredential(string apikey, string secretkey)
        {
            string uri = string.Format("https://api.nexmo.com/verify/json?api_key={0}&api_secret={1}", apikey, secretkey);
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Method = "GET";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            string result = string.Empty;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                result = reader.ReadToEnd();
            }
            return true;

        }
    }
    public class Number
    {
        public string country { get; set; }
        public string msisdn { get; set; }
        public string type { get; set; }
        public List<string> features { get; set; }
    }

    public class RootObject
    {
        public int count { get; set; }
        public List<Number> numbers { get; set; }
    }
}
