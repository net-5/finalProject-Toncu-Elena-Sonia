using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Service;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Conference.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("sponsorTypes", Attributes=ForAttributeName)]
    public class SponsorTypesTagHelper : TagHelper
    {
        private readonly ISponsorTypeService sponsorTypesService;
        private const string ForAttributeName = "asp-for";
        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }

        public SponsorTypesTagHelper(ISponsorTypeService sponsorTypesService)
        {
            this.sponsorTypesService = sponsorTypesService;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var allSponsorType = sponsorTypesService.GetAllSponsorTypes();
            output.TagName = "select";
            output.Attributes.SetAttribute("id", For.Name);
            output.Attributes.SetAttribute("name", For.Name);

            output.Attributes.Add("class", "form-control");
            foreach (var sponsorTypes in allSponsorType)
            {
                TagBuilder myOption = new TagBuilder("option")
                {
                    TagRenderMode = TagRenderMode.Normal
                };
                myOption.Attributes.Add("value", sponsorTypes.Id.ToString());
                myOption.InnerHtml.Append(sponsorTypes.Name);
                output.Content.AppendHtml(myOption);
            }

        }
    }
}
