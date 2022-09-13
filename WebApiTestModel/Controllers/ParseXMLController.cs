using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;

namespace WebApiTestModel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParseXMLController : ControllerBase
    {
        private readonly ILogger<ParseXMLController> _logger;

        public ParseXMLController(ILogger<ParseXMLController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name ="TestPost")]
        [Consumes("application/xml")]
        public IActionResult Create([FromBody]NaklDto nakl)
        {

            /*Пример как принимать XML для POST запроса
             * 
             * Чтобы сформировались классы для XML нужно скопировать ее в буфер
             * в VS - Edit - Paste Special - Parxe XML to Classes
             * 
             * После генкрации классов для DTO можно приватные пол и свойства
             * заменить на автосвойства
             * 
             * 
             Такую XML нужно кинуть на вход для ендпоинта
  <NaklDto>
  <dwhNaklId>209386678</dwhNaklId>
  <doctypeId>3</doctypeId>
  <dateProved>2022-09-06T15:33:40.563</dateProved>
  <dateClient>2022-08-23T00:00:00</dateClient>
  <status>3</status>
  <sapCounter>AS77101UDO</sapCounter>
  <contractNumber>6930106261</contractNumber>
  <fromId>196</fromId>
  <storeId>19</storeId>
  <sumNakl>330.25</sumNakl>
  <sumNaklNoTax>330.25000</sumNaklNoTax>
  <NaklLines>
    <lagerId>406</lagerId>
    <lineId>1</lineId>
    <filId>1998</filId>
    <kolvo>5.000</kolvo>
    <priceIn>10.17000</priceIn>
    <priceWithoutTax>10.1700000</priceWithoutTax>
    <sumTax>0.00</sumTax>
    <sumNoTax>50.85</sumNoTax>
    <MRP>0.00</MRP>
    <MRPBase>0.00</MRPBase>
  </NaklLines>
  <NaklLines>
    <lagerId>412</lagerId>
    <lineId>2</lineId>
    <filId>1998</filId>
    <kolvo>5.000</kolvo>
    <priceIn>9.91000</priceIn>
    <priceWithoutTax>9.9100000</priceWithoutTax>
    <sumTax>0.00</sumTax>
    <sumNoTax>49.55</sumNoTax>
    <MRP>0.00</MRP>
    <MRPBase>0.00</MRPBase>
  </NaklLines>
  <NaklLines>
    <lagerId>410</lagerId>
    <lineId>3</lineId>
    <filId>1998</filId>
    <kolvo>5.000</kolvo>
    <priceIn>20.55000</priceIn>
    <priceWithoutTax>20.5500000</priceWithoutTax>
    <sumTax>0.00</sumTax>
    <sumNoTax>102.75</sumNoTax>
    <MRP>0.00</MRP>
    <MRPBase>0.00</MRPBase>
  </NaklLines>
  <NaklLines>
    <lagerId>420</lagerId>
    <lineId>4</lineId>
    <filId>1998</filId>
    <kolvo>5.000</kolvo>
    <priceIn>10.33000</priceIn>
    <priceWithoutTax>10.3300000</priceWithoutTax>
    <sumTax>0.00</sumTax>
    <sumNoTax>51.65</sumNoTax>
    <MRP>0.00</MRP>
    <MRPBase>0.00</MRPBase>
  </NaklLines>
  <NaklLines>
    <lagerId>419</lagerId>
    <lineId>5</lineId>
    <filId>1998</filId>
    <kolvo>5.000</kolvo>
    <priceIn>15.09000</priceIn>
    <priceWithoutTax>15.0900000</priceWithoutTax>
    <sumTax>0.00</sumTax>
    <sumNoTax>75.45</sumNoTax>
    <MRP>0.00</MRP>
    <MRPBase>0.00</MRPBase>
  </NaklLines>
</NaklDto>
             
             */

            
            //тут какая то логика по обработке XML или маппинг и проброс дальше в код

            return Ok();
        }
    }
   
}