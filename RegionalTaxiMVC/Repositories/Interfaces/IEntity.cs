namespace RegionalTaxiMVC.Repositories.Interfaces;

public interface IEntity<T>
{
    T Id { get; init; }
}
