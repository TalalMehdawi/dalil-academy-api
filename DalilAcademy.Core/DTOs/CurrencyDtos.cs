namespace DalilAcademy.Core.DTOs;
public record ConvertPriceRequsetDto(decimal Amount,string FromCurrency,string ToCurrency);


public record ConvertPriceResponseDto(decimal OriginalAmount,string FromCurrency,decimal ConvertedAmount,string ToCurrency,decimal ExchangeRate);