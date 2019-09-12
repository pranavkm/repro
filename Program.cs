using Pcs.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            };
            var str = @"[{""id"":76274891648667648,""sn"":""c570fc7894134e259673eb60f544603c"",""userId"":76233691482816512,""totalAmount"":0.01,""netAmount"":0.01,""discountAmount"":0.00,""taxAmount"":0.00,""otherAmount"":0.00,""refundAmount"":0.00,""freightCharge"":0.00,""paymentAmount"":0.00,""currency"":""CNY"",""orderState"":70,""paymentState"":2,""shippingState"":5,""refundState"":0,""returnState"":0,""paymentMethod"":8,""shippingMethod"":1,""userMobile"":""17610175201"",""userIp"":""::ffff:127.0.0.1"",""userEnd"":2,""createdBy"":76233691482816512,""updatedBy"":76233691482816512,""createdOn"":""2019-07-30T11:29:13+00:00"",""updatedOn"":""2019-08-01T09:18:58+00:00"",""applicationId"":0,""businessType"":1,""remark"":"""",""payTime"":""2019-07-30T11:29:23+00:00"",""paymentMode"":2,""parentId"":0,""title"":""ESCASE \u5C0F\u7C738SE\u624B\u673A\u58F3(\u7EA2)"",""clientId"":""aifouliteapp"",""affiliateId"":"""",""fromItemId"":0,""fromContributorId"":0,""fromUserId"":0,""orderItems"":[{""id"":76274891652861952,""orderId"":76274891648667648,""orderSn"":""c570fc7894134e259673eb60f544603c"",""userId"":76233691482816512,""itemId"":71123747733504000,""skuId"":71125725242982400,""price"":0.01,""quantity"":1.000000,""netAmount"":0.01,""totalAmount"":0.00,""discountAmount"":0.00,""taxAmount"":0.00,""returnQuantity"":0.000000,""refundAmount"":0.00,""currency"":"""",""businessType"":1,""createdOn"":""2019-07-30T11:29:13+00:00"",""updatedOn"":""2019-07-30T11:29:13+00:00"",""createdBy"":76233691482816512,""updatedBy"":0,""name"":""ESCASE \u5C0F\u7C738SE\u624B\u673A\u58F3(\u7EA2)"",""brandName"":"""",""skuSn"":""dddddd"",""usageQuantity"":0.000000,""totalQuantity"":1.000000,""costPrice"":0.01,""skuValues"":""[{\u0022code\u0022:\u002298f201ac142d454a9758a5ff83209a60\u0022,\u0022propertyId\u0022:29,\u0022propertyName\u0022:\u0022\u989C\u8272\u0022,\u0022name\u0022:\u0022\u7EA2\u8272\u0022,\u0022value\u0022:\u0022\u7EA2\u8272\u0022,\u0022flags\u0022:1},{\u0022code\u0022:\u0022656a97b7d9614655a1808ccd803b2b22\u0022,\u0022propertyId\u0022:30,\u0022propertyName\u0022:\u0022\u5C3A\u5BF8\u0022,\u0022name\u0022:\u00226.1\u5BF8\u0022,\u0022value\u0022:\u00226.1\u5BF8\u0022,\u0022flags\u0022:1},{\u0022code\u0022:\u00222cd9f34c0ad547988698d9887d93848e\u0022,\u0022propertyId\u0022:31,\u0022propertyName\u0022:\u0022\u6750\u8D28\u0022,\u0022name\u0022:\u0022\u7845\u80F6\u0022,\u0022value\u0022:\u0022\u7845\u80F6\u0022,\u0022flags\u0022:1}]"",""commissionRate"":10.00,""values"":[{""id"":105,""orderItemId"":76274891652861952,""skuValueId"":15,""propertyId"":29,""propertyName"":""\u989C\u8272"",""name"":""\u7EA2\u8272"",""value"":""\u7EA2\u8272"",""createdBy"":76233691482816512,""updatedBy"":76233691482816512,""createdOn"":""2019-07-30T11:29:13+00:00"",""updatedOn"":""2019-07-30T11:29:13+00:00"",""state"":1,""orderId"":76274891648667648,""propertyCode"":""98f201ac142d454a9758a5ff83209a60""},{""id"":106,""orderItemId"":76274891652861952,""skuValueId"":17,""propertyId"":30,""propertyName"":""\u5C3A\u5BF8"",""name"":""6.1\u5BF8"",""value"":""6.1\u5BF8"",""createdBy"":76233691482816512,""updatedBy"":76233691482816512,""createdOn"":""2019-07-30T11:29:13+00:00"",""updatedOn"":""2019-07-30T11:29:13+00:00"",""state"":1,""orderId"":76274891648667648,""propertyCode"":""656a97b7d9614655a1808ccd803b2b22""},{""id"":107,""orderItemId"":76274891652861952,""skuValueId"":18,""propertyId"":31,""propertyName"":""\u6750\u8D28"",""name"":""\u7845\u80F6"",""value"":""\u7845\u80F6"",""createdBy"":76233691482816512,""updatedBy"":76233691482816512,""createdOn"":""2019-07-30T11:29:13+00:00"",""updatedOn"":""2019-07-30T11:29:13+00:00"",""state"":1,""orderId"":76274891648667648,""propertyCode"":""2cd9f34c0ad547988698d9887d93848e""}],""sku"":{""id"":71125725242982400,""itemId"":71123747733504000,""name"":""ESCASE \u5C0F\u7C738SE\u624B\u673A\u58F3(\u7EA2)"",""price"":0.01,""stockState"":1,""stockRemark"":"""",""stockQuantity"":1000.000000,""barCode"":""dddddd"",""state"":1,""sourceId"":0,""merchantId"":0,""vendorId"":0,""soldQuantity"":0.000000,""currency"":""CNY"",""updatedOn"":""2019-07-16T06:44:40+00:00"",""createdOn"":""2019-07-16T06:28:14+00:00"",""originalPrice"":25.00,""createdBy"":92,""updatedBy"":92,""applicationId"":2,""sn"":""dddddd"",""userId"":92,""tenantId"":0,""categoryId"":11,""unitQuantity"":1.000000,""costPrice"":0.01,""minLimits"":1.000000,""maxLimits"":100.000000,""saleState"":1,""listState"":1,""title"":""ESCASE \u5C0F\u7C738SE\u624B\u673A\u58F3(\u7EA2)"",""warehouseId"":1,""commissionRate"":10.00,""brandId"":8}}]}]";
            var list = System.Text.Json.JsonSerializer.Deserialize<List<Order>>(str, options);

            using (var stream = new MemoryStream())
            {
                await JsonSerializer.SerializeAsync(stream, list, options);
                await stream.FlushAsync();

                Console.WriteLine(Encoding.UTF8.GetString(stream.ToArray()));
            }
        }
    }
}
