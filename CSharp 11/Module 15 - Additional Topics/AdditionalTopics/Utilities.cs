using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTopics
{
    internal static class Utilities
    {
        public static Dictionary<string, List<string>> ExtractErrorsFromWebAPI(string json)
        {
            var response = new Dictionary<string, List<string>>();

            var deserialized = JsonConvert.DeserializeObject<dynamic>(json)!;
            var errorFields = deserialized.errors;

            foreach (dynamic fieldWithErrors in errorFields)
            {
                var field = fieldWithErrors.Name;
                var errors = new List<string>();
                foreach (var error in fieldWithErrors.Value)
                {
                    errors.Add(error.ToString());
                }
                response.Add(field, errors);
            }

            return response;
        }
    }
}
