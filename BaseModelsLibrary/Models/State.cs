using System.ComponentModel.DataAnnotations;

namespace BaseModelsLibrary.Models;

    public class State
    {
        public int Id { get; set; }
        [AllowedValues("Alaska", "Oregon", "Hawaii", 
            ErrorMessage = "Invalid state")]
        public string Name { get; set; }

        [DeniedValues("11111", 
            ErrorMessage = "Invalid postal code")]
        public string PostalCode { get; set; }
    }

