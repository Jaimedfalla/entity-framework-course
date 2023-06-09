using System.ComponentModel.DataAnnotations;

namespace webapi.DTOs;

public class CinemaOfferCreateDto
{
    [Range(1,100)]
    public double Discount { get; set; }
    public DateTime InitialDate { get; set; }
    public DateTime EndDate { get; set; }
}