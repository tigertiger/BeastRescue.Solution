using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BeastRescueClient.Models
{
    public class Beast
    {
        public int BeastId { get; set; }
        public string Name { get; set; }
        [Required]
        public string Species { get; set; }
        public string Temperment {get; set;}
        public string Description {get; set;}
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Photo {get; set;}

        public static List<Beast> GetBeasts()
        {
        var apiCallTask = ApiHelper.GetAll();
        var result = apiCallTask.Result;

        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Beast> beastList = JsonConvert.DeserializeObject<List<Beast>>(jsonResponse.ToString());

        return beastList;
        }

        public static Beast GetDetails(int id)
        {
        var apiCallTask = ApiHelper.Get(id);
        var result = apiCallTask.Result;

        JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
        Beast beast = JsonConvert.DeserializeObject<Beast>(jsonResponse.ToString());

        return beast;
        }
    }
}
