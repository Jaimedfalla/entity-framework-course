using NetTopologySuite.Geometries;

namespace Domain.Entities;

public class Cinema
{
    public int Id { get; set; }
    public string Name {get; set; }
    public Point Location { get; set; }
    public CinemaOffer Offer { get; set; }
    public HashSet<MovieTheater> MovieTheaters{ get; set; }
    public CinemaDetail Detail { get; set; }
    public Address Address { get; set; }
}