using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NickLearning.HighLowBettingGame.Helpers
{
    public static class Enumerators
    {
        #region Enumerators
        public enum ElementStyle
        {
            [Description("Info")]
            [Display(Name = "Info")]
            Info = 1,
            [Description("Success")]
            [Display(Name = "Success")]
            Success = 2,
            [Description("Warning")]
            [Display(Name = "Warning")]
            Warning = 3,
            [Description("Danger")]
            [Display(Name = "Danger")]
            Danger = 4,
        }
        #endregion
    }
}
