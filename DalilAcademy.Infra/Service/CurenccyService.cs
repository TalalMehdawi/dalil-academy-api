using System;

using DalilAcademy.Core.Service;
using DalilAcademy.Core.DTOs;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
namespace DalilAcademy.Infra.Service;

public class CurenccyService(HttpClient httpClient) : ICurrencyService
{
    private record PairResponse([property: JsonPropertyName("conversion_rate")] decimal ConversionRate);
    public async Task <ConvertPriceResponseDto>Convert(ConvertPriceRequsetDto r)
    {
        var data = await httpClient.GetFromJsonAsync<PairResponse>($"pair/{r.FromCurrency}/{r.ToCurrency}")
        ?? throw new HttpRequestException("Empty Respone From ExchangeRate-Api");

        var converted=Math.Round(r.Amount*data.ConversionRate,2);
        return new ConvertPriceResponseDto(r.Amount,r.FromCurrency,converted,r.ToCurrency,data.ConversionRate);

    }


}
