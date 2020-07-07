using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace NickLearning.HighLowBettingGame.TagHelpers
{
    public class GuessControlTagHelper : TagHelper
    {

        #region Properties

        private const string ASP_ATTRIBUTE_COUNTER = "asp-counter";

		private const string HTML_GUESS_CONTROL =
            @"<div class=""guess-control"" data-counter=""[COUNTER]"" style=""display: [DISPLAY]"">
	            <div class=""mb-3 guess-input-container"" data-counter=""[COUNTER]"">
		            <div class=""d-flex"">
			            <span class=""badge badge-light mr-3 fs-24"">
				            Guess [COUNTER]:
			            </span>
			            <div class=""flex-fill"">
				            <div class=""input-group"">
					            <input type=""tel"" maxlength=""3"" class=""form-control guess-input"" data-counter=""[COUNTER]"" />
					            <div class=""input-group-append"">
						            <button class=""btn btn-success guess-button"" type=""button"" data-counter=""[COUNTER]""><i class=""fas fa-check-circle""></i></button>
					            </div>
				            </div>
			            </div>
		            </div>
	            </div>
	            <div class=""mb-3 guess-display-container"" data-counter=""[COUNTER]"" style=""display:none;"">
		            <div class=""d-flex"">
			            <span class=""badge badge-light mr-3 fs-24"">
				            Guess [COUNTER]:
			            </span>
			            <div class=""flex-fill"">
				            <span class=""badge badge-secondary mr-3 guess-display fs-24"" data-counter=""[COUNTER]"">
				            </span>
				            <span class=""badge guess-result float-right fs-24"" data-counter=""[COUNTER]"">
				            </span>
			            </div>
		            </div>
	            </div>
            </div>";

        [HtmlAttributeName(ASP_ATTRIBUTE_COUNTER)]
        public int Counter { get; set; }

		#endregion

		#region Calculated Properties


		#endregion

		#region Process Methods

		public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
			var display = "none";
			string htmlGuessControl = await Task.Run(() =>
                HTML_GUESS_CONTROL
                    .Replace("[COUNTER]", Counter.ToString())
					.Replace("[DISPLAY]", display)
			);
            output.Content.SetHtmlContent(htmlGuessControl);
        }

        #endregion

        #region Helper Methods


        #endregion

    }
}
