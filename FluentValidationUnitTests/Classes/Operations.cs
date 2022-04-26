using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FluentValidationUnitTests.Classes
{
    public class Operations
    {
        public static async Task<List<OregonInformation>> ReadOregonInformation()
        {
            var json = await File.ReadAllTextAsync("Oregon.json");
            return JsonConvert.DeserializeObject<List<OregonInformation>>(json); ;
        }
    }
}
