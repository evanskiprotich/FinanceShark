using FinSharkAPI.Dtos.Stock;
using FinSharkAPI.Models;

namespace FinSharkAPI.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockmodel)
        {
            return new StockDto
            {
                Id = stockmodel.Id,
                Symbol = stockmodel.Symbol,
                CompanyName = stockmodel.CompanyName,
                Industry = stockmodel.Industry,
                Purchase = stockmodel.Purchase,
                LastDiv = stockmodel.LastDiv,
                MarketCap = stockmodel.MarketCap,
                Comments = stockmodel.Comments.Select(c => c.ToCommentDto()).ToList(),
            };
        }

        public static Stock ToStockFromCreateDto(this CreateStockRequestDto createStockRequestDto)
        {
            return new Stock
            {
                Symbol = createStockRequestDto.Symbol,
                CompanyName = createStockRequestDto.CompanyName,
                Industry = createStockRequestDto.Industry,
                Purchase = createStockRequestDto.Purchase,
                LastDiv = createStockRequestDto.LastDiv,
                MarketCap = createStockRequestDto.MarketCap,
            };
        }
    }
}
