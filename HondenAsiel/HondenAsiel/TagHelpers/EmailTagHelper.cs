using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.TagHelpers
{
    public class EmailTagHelper:TagHelper
    {
        public string Adress { get; set; }

        public string Bericht { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Adress);
            output.Content.SetContent(Bericht);
        }

    }
}
