using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RenrenCore.Constants;
using RenrenCore.Entities;
using RenrenCore.Helper;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;

namespace RenrenCore.Helper
{
    public class ApiHelper
    {
        public static List<RequestParameterEntity> GetBaseParameters(string apiMethod, string access_token)
        {
            List<RequestParameterEntity> baseParameters = new List<RequestParameterEntity>();
            baseParameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            baseParameters.Add(new RequestParameterEntity("v", "1.0"));
            baseParameters.Add(new RequestParameterEntity("call_id", GenerateTime()));
            baseParameters.Add(new RequestParameterEntity("method", apiMethod));
            baseParameters.Add(new RequestParameterEntity("gz", "compression"));
            if (!String.IsNullOrEmpty(access_token))
            {
                baseParameters.Add(new RequestParameterEntity("access_token", access_token));
            }
            return baseParameters;
        }

        public async static Task<List<RequestParameterEntity>> GetBaseParameters(string sessionKey = "")
        {
            List<RequestParameterEntity> baseParameters = new List<RequestParameterEntity>();
            //baseParameters.Add(new RequestParameterEntity("api_key", ConstantValue.ApiKey));
            //baseParameters.Add(new RequestParameterEntity("v", "1.0"));

            IDeviceInfoHelper deviceHelper = new DeviceInfoAdaptor(DeviceInfoAdaptor.ImplType.NETWORKADAPTOR);
            var clientInfo = await deviceHelper.GetClientInfo();
            baseParameters.Add(new RequestParameterEntity("client_info", clientInfo));
            baseParameters.Add(new RequestParameterEntity("gz", "compression"));
            //if (!String.IsNullOrEmpty(sessionKey))
            //{
            //    baseParameters.Add(new RequestParameterEntity("session_key", sessionKey));
            //}
            return baseParameters;
        }

        public static string GenerateSig(List<RequestParameterEntity> Parameters, string key)
        {
            StringBuilder sb = new StringBuilder();

            Parameters.Sort(new ParameterComparer());
            foreach (var requestParameter in Parameters)
            {
                sb.Append(string.Format("{0}={1}", requestParameter.Name, requestParameter.Values.Length < 50 ? requestParameter.Values : requestParameter.Values.Substring(0, 50)));
            }
            sb.Append(key);

            Debug.WriteLine("###Compute Sig original string: ", sb.ToString());
            byte[] bytes = Encoding.UTF8.GetBytes(sb.ToString());
            return MD5Core.GetHashString(bytes);
        }

        public static string GenerateTime()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }

        //取大头像
        public static string GetLargeHeaderUrl(int uid, int width)
        {
            Random r = new Random();
            int index = r.Next(5000);
            return "http://ic.m.renren.com/gn?op=resize&w=" + width.ToString() + "&p=" + uid.ToString() + "-L&a=" + index.ToString();
        }

        //取大头像
        public static string GetLargeHeaderUrl(int uid, int width, int height)
        {
            Random r = new Random();
            int index = r.Next(5000);
            return "http://ic.m.renren.com/gn?op=resize&w=" + width.ToString() + "&h=" + height.ToString() + "&p=" + uid.ToString() + "-L&a=" + index.ToString();
        }

        public async static Task<IRandomAccessStream> ScaleImage2Fit(IRandomAccessStream source, int maxWidth)
        {
            InMemoryRandomAccessStream inMemoryStream = new InMemoryRandomAccessStream();

            // Decode the image
            BitmapDecoder imageDecoder = await BitmapDecoder.CreateAsync(source);

            // Re-encode the image at maxWidth
            if (imageDecoder.OrientedPixelWidth > maxWidth)
            {
                double rat = maxWidth / imageDecoder.OrientedPixelWidth;
                BitmapEncoder imageEncoder = await BitmapEncoder.CreateForTranscodingAsync(inMemoryStream, imageDecoder);
                imageEncoder.BitmapTransform.ScaledWidth = (uint)(imageDecoder.OrientedPixelWidth * rat);
                imageEncoder.BitmapTransform.ScaledHeight = (uint)(imageDecoder.OrientedPixelHeight * rat);
                await imageEncoder.FlushAsync();

                return inMemoryStream;
            }
            else
            {
                return source;
            }
        }
    }
}
