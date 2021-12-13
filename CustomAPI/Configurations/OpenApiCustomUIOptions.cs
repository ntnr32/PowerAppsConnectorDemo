using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAPI.Configurations
{
    public class OpenApiCustomUIOptions : DefaultOpenApiCustomUIOptions
    {
        public OpenApiCustomUIOptions(Assembly assembly) : base(assembly)
        {
        }

        public override string CustomStylesheetPath => "dist.styles.css";

        public override string CustomJavaScriptPath => "dist.script.js";
    }
}
