﻿using Microsoft.AspNet.Razor.Runtime.TagHelpers;

namespace TagHlp.TagHelpers
{
    [TargetElement(Attributes = "bold")]
    public class BoldTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("bold");
            output.PreContent.SetContent("<b>");
            output.PostContent.SetContent("</b>");
        }
    }
}
