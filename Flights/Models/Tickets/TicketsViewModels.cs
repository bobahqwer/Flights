using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Flights.Models.Tickets
{
    public class TicketsViewModels
    {
        [Key]
        public int TicketsId { get; set; }
        [Display(Name = "The Request")]
        public Request Request { get; set; }
    }

    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        [Display(Name = "The Request")]
        public Passengers Passengers { get; set; }
        [Display(Name = "The Request")]
        public Slouse[] Slice { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Choose max price")]
        public string MaxPrice { get; set; }

        [Required]
        [Display(Name = "Choose distination country")]
        public string SaleCountry { get; set; }

        [Required]
        [Display(Name = "Is refundable")]
        public bool Refundable { get; set; }

        [Required]
        [Display(Name = "Choose solutions")]
        public int Solutions { get; set; }
    }

    public class Passengers
    {
        [Key]
        public int PassengersId { get; set; }
        [Display(Name = "Choose solutions")]
        public string Kind { get; set; }
        [Display(Name = "Choose solutions")]
        public int AdultCount { get; set; }
        [Display(Name = "Choose solutions")]
        public int ChildCount { get; set; }
        [Display(Name = "Choose solutions")]
        public int InfantInLapCount { get; set; }
        [Display(Name = "Choose solutions")]
        public int InfantInSeatCount { get; set; }
        [Display(Name = "Choose solutions")]
        public int SeniorCount { get; set; }
    }

    public class Slouse
    {
        [Key]
        public int SlouseId { get; set; }
        [Display(Name = "Choose solutions")]
        public string Kind { get; set; }
        [Display(Name = "Choose solutions")]
        public string Origin { get; set; }
        [Display(Name = "Choose solutions")]
        public string Destination { get; set; }
        [Display(Name = "Choose solutions")]
        public string Date { get; set; }
        [Display(Name = "Choose solutions")]
        public int MaxStops { get; set; }
        [Display(Name = "Choose solutions")]
        public int MaxConnectionDuration { get; set; }
        [Display(Name = "Choose solutions")]
        public string PreferredCabin { get; set; }
        [Display(Name = "Choose solutions")]
        public Permitteddeparturetime PermittedDepartureTime { get; set; }
        [Display(Name = "Choose solutions")]
        public string[] PermittedCarrier { get; set; }
        [Display(Name = "Choose solutions")]
        public string Alliance { get; set; }
        [Display(Name = "Choose solutions")]
        public string[] ProhibitedCarrier { get; set; }
    }

    public class Permitteddeparturetime
    {
        [Key]
        public int PermitteddeparturetimeId { get; set; }
        [Display(Name = "Choose solutions")]
        public string Kind { get; set; }
        [Display(Name = "Choose solutions")]
        public string EarliestTime { get; set; }
        [Display(Name = "Choose solutions")]
        public string LatestTime { get; set; }
    }
}