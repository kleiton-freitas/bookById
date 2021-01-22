using BookByIdApi.Model;
namespace BookByIdApi.Repository.Contracts
{
    public interface ICategoryRepository
    {
        EstablishmentCategory FindByFilter(string name);
    }
}
