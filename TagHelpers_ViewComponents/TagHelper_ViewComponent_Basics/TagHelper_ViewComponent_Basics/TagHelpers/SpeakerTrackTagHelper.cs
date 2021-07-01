using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelper_ViewComponent_Basics.TagHelpers
{
    [HtmlTargetElement("speaker-track")]
    public class SpeakerTrackTagHelper : TagHelper
    {
        
        public string TrackName { get; set; }

        public override void Process(TagHelperContext context,
            TagHelperOutput output)
        {
            string preContent = $@"
                <h2 style=color:red>{TrackName}</h2>
                <div class='row'>
            ";
            const string postContent = @"
                </div>
            ";
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "track");
            output.PreContent.SetHtmlContent(preContent);
            output.PostContent.SetHtmlContent(postContent);
        }
    }
}