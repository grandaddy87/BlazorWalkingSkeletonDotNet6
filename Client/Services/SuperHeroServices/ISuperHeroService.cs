global using BlazorWalkingSkeleton.Shared;

namespace BlazorWalkingSkeleton.Client.Services.SuperHeroServices
{
    public interface ISuperHeroService
    {
        List<SuperHero> SuperHeroes { get; set; }
        Task GetSuperHeroes();
    }
}
