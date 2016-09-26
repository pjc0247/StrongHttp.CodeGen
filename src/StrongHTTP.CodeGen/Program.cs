using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongHTTP.CodeGen
{
    using Templates;

    public class API
    {
        public string name { get; set; }
        public string path { get; set; }
        public string method { get; set; }
    }
    public class Service
    {
        public string name { get; set; }

        public List<API> apis { get; set; }

        public Service()
        {
            apis = new List<API>();
        }
    }
    public class G
    {
        private InterfaceFileTemplate template { get; set; }

        private API currentAPI { get; set; }
        private Service currentService { get; set; }

        public static G Namespace(string @namespace)
        {
            var g = new G(@namespace);

            return g;
        }

        public G(string @namespace)
        {
            template = new InterfaceFileTemplate();
            template.@namespace = @namespace;
            template.services = new List<Service>();
        }

        public G Service(string name)
        {
            currentService = new Service();
            currentService.name = name;
            
            template.services.Add(currentService);

            return this;
        }

        public G Get(string name, string path)
        {
            currentAPI = new API();
            currentAPI.method = "GET";
            currentAPI.name = name;
            currentAPI.path = path;

            currentService.apis.Add(currentAPI);

            return this;
        }

        public string Generate()
        {
            return template.TransformText();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var g = G.Namespace("Rini.Game")
                .Service("player")
                    .Get("GetProfile", "profile");

            Console.WriteLine(g.Generate());
        }
    }
}
