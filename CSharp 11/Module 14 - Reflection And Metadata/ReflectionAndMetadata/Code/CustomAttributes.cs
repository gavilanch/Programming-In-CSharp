using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata.Code
{
    internal class CustomAttributes
    {
        public void TheCode()
        {
            Console.WriteLine("--You can make the following actions--");

            foreach (var action in Enum.GetValues<Actions>())
            {
                var field = typeof(Actions).GetField(action.ToString())!;
                var hideAttribute = field.GetCustomAttribute(typeof(HideAttribute));

                if (hideAttribute is not null)
                {

                    var hide = ((HideAttribute)hideAttribute).Hide();

                    if (hide)
                    {
                        continue;
                    }
                }

                Console.WriteLine(action);
            }
        }
    }
}
