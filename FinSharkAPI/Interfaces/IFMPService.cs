using FinSharkAPI.Models;

namespace FinSharkAPI.Interfaces
{
    public interface IFMPService
    {
        Task<Stock> FindStockBySymbolAsync(string symbol);
    }
}
