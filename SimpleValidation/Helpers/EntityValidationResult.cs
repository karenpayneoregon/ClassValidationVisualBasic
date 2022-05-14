using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleValidation.Helpers
{
    public class EntityValidationResult
    {
        public IList<ValidationResult> Errors { get; set; }

        public bool HasError => Errors.Count > 0;

        public bool IsValid => Errors.Count == 0;
        public bool IsNotValid => Errors.Count > 0;

        public EntityValidationResult(IList<ValidationResult> errors = null)
        {
            this.Errors = errors ?? new List<ValidationResult>();
        }
    }
}