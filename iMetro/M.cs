using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace iMetro
{
    class M
    {
        private static string appid = "wxe8d80836d14253da";
        private static string appsecret = "c139e9fc56c9563cad533dd19ab0bf53";
        private static string env = "imetro-s8ara";
        private string access_token;
        public M()
        {
            string url = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=" + M.appid + "&secret=" + M.appsecret;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

            string access_token = reader.ReadToEnd();
            this.access_token = access_token.Substring(17, 157);

            reader.Close();
            response.Close();

        }

        public string get_access_token()
        {
            return this.access_token;
        }

        public string post(string url, string postbody)
        {
            url += "?access_token=" + this.access_token;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";

            StreamWriter writer = new StreamWriter(request.GetRequestStream());
            writer.Write(postbody);
            writer.Flush();
            writer.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

            string result = reader.ReadToEnd();

            reader.Close();
            response.Close();
            return result;

        }

        public string query(string query)
        {
            string url = "https://api.weixin.qq.com/tcb/databasequery";
            string postbody = "{\"env\":\"" + M.env + "\",\"query\":\"" + query + "\"}";
            string result = this.post(url, postbody);
            return result;
        }

        public string query(string table, string where, string limit, string field)
        {
            string url = "https://api.weixin.qq.com/tcb/databasequery";
            string query = "db.collection('" + table + "').where(" + where + ").limit(" + limit + ").field(" + field + ").get()";
            //System.Diagnostics.Debug.WriteLine(query);
            string postbody = "{\"env\":\"" + M.env + "\",\"query\":\"" + query + "\"}";
            string result = this.post(url, postbody);
            return result;
        }


    }
}
