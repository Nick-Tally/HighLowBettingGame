using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using NickLearning.HighLowBettingGame.Helpers;

namespace NickLearning.HighLowBettingGame.TagHelpers
{
    public class BankPanelTagHelper : TagHelper
    {

        #region Properties

        private const string ASP_ATTRIBUTE_LABEL = "asp-label";
        private const string ASP_ATTRIBUTE_VALUE = "asp-value";
        private const string ASP_ATTRIBUTE_STYLE = "asp-style";
        private const string ASP_ATTRIBUTE_ICON = "asp-icon";

        private const string HTML_SUMMARY_PANEL =
            @"<div class=""d-flex shadow"">
				<div class=""[STYLE] border border-right-0 rounded-left px-4 py-3 bank-panel-bg"">
					<i class=""[ICON] fs-20 align-middle""></i>
				</div>
				<div class=""text-secondary border border-left-0 rounded-right lh-13 flex-grow-1 text-right py-1 px-3"">
					<p class=""mb-0""><small>[LABEL]</small></p>
					<p class=""font-weight-bold mb-0 fs-20 bank-panel-value"">[VALUE]</p>
				</div>
			</div>";

        [HtmlAttributeName(ASP_ATTRIBUTE_LABEL)]
        public string Label { get; set; }
        [HtmlAttributeName(ASP_ATTRIBUTE_VALUE)]
        public string Value { get; set; }
        [HtmlAttributeName(ASP_ATTRIBUTE_STYLE)]
        public Enumerators.ElementStyle Style { get; set; }
        [HtmlAttributeName(ASP_ATTRIBUTE_ICON)]
        public string Icon { get; set; }

        #endregion

        #region Calculated Properties


        #endregion

        #region Process Methods

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            string style = "bg-info text-white";
            switch (Style)
            {
                case Enumerators.ElementStyle.Info:
                    style = "bg-info text-white";
                    break;
                case Enumerators.ElementStyle.Success:
                    style = "bg-success text-white";
                    break;
                case Enumerators.ElementStyle.Warning:
                    style = "bg-warning text-dark";
                    break;
                case Enumerators.ElementStyle.Danger:
                    style = "bg-danger text-white";
                    break;
            }
            string htmlSummaryPanel = await Task.Run(() =>
                HTML_SUMMARY_PANEL
                    .Replace("[LABEL]", Label)
                    .Replace("[VALUE]", Value)
                    .Replace("[STYLE]", style)
                    .Replace("[ICON]", Icon)
            );
            output.Content.SetHtmlContent(htmlSummaryPanel);
        }

        #endregion

        #region Helper Methods


        #endregion

    }
}
