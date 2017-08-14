using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Para las peticiones web
using System.Net;
//Para Flujo de datos
using System.IO;

namespace Parcel
{
    class Service
    {
        private string url { get; set; }

        private HttpWebRequest httpRequest { get; set; }

        private HttpWebResponse httpResponse { get; set; }

        private StreamReader streamReader { get; set; }

        private StreamWriter streamWriter { get; set; }

        private string body { get; set; }

        private string results { get; set; }

        public Service()
        {
            url = "http://localhost/Parcel/Server/";
            httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.ContentType = "application/json";
            httpRequest.Method = "Post";
            streamWriter = new StreamWriter(httpRequest.GetRequestStream());
        }

        public string callService(string parameters)
        {
            body = parameters;
            //escribimos la peticion al servicio
            streamWriter.InitializeLifetimeService();
            streamWriter.Write(body);
            streamWriter.Flush();
            //Obtener la respuesta del web service
            httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            using (streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                results = streamReader.ReadToEnd();
            }
            return results;
        }
    };
}
