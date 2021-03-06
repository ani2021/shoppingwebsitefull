using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Oasis.Services
{
	public static class JavaScriptConvertService
	{
    public static HtmlString SerializeObject(object value)
    {
      using(var stringWriter = new StringWriter())
      using(var jsonWriter = new JsonTextWriter(stringWriter))
      {
        var serializer = new JsonSerializer
        {
          ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        jsonWriter.QuoteName = false;
        serializer.Serialize(jsonWriter, value);

        return new HtmlString(stringWriter.ToString());
      }
    }
  }
}