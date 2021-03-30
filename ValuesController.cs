using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
        public static List<string> names = new List<string>();

        public ValuesController()
        {
            names.Add("Akanksha");
            names.Add("Rashmi");
            names.Add("Ashitha");
            names.Add("Krutika");

        }
        // GET api/values
        public IEnumerable<string> GetNames()
        {

            return names;
        }

        // GET api/values/5
        public string GetNamesById(int id)
        {
            string name =names[id];
            return "Name = " + name;
        }

        // POST api/values
        public void PostName([FromBody]string value)
        {
            names.Add(value);
        }

        // PUT api/values/5
        public void PutName(int id, [FromBody]string value)
        {
            for (int i = 0; i < names.Count; i++)
            {
                string foundname=names[id];
                if (names[i].Contains(foundname))
                {
                    names[i] = value;
                }
            }
            
        }

        // DELETE api/values/5
        public void DeleteName(int id)
        {
            string name=names[id];
            names.Remove(name);
        }
    }
}
