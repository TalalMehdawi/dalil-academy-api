using System;
using DalilAcademy.Core.DTOs;
namespace DalilAcademy.Core.Service;

public interface ICurrencyService
{
    Task <ConvertPriceResponseDto>Convert(ConvertPriceRequsetDto requset);
}
