using System;
using System.ComponentModel.DataAnnotations;

namespace BaseModelsLibrary.Rules
{

    /// <summary>
    /// Disallow date to be a weekend date
    /// </summary>
    public class WeekendDateNotPermittedAttribute : ValidationAttribute
    {
        public override bool IsValid(object senderDate)
        {
            DateTime d = Convert.ToDateTime(senderDate);
            return d.DayOfWeek != DayOfWeek.Saturday && d.DayOfWeek != DayOfWeek.Sunday;
        }
    }

}