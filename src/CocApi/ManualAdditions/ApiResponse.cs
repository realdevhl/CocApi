﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CocApi.Client
{
    public partial class ApiResponse<T>
    {
        public DateTime Downloaded 
        { 
            get
            {
                string downloadDateString = Headers.First(h => h.Key == "Date").Value.First();
                DateTime downloadDate = DateTime.ParseExact(downloadDateString, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture);

                return downloadDate;
            }
        }

        public DateTime ServerExpiration
        {
            get
            {
                string cacheControlString = Headers.First(h => h.Key == "Cache-Control").Value.First().Replace("max-age=", "");
                double cacheControl = double.Parse(cacheControlString);
                return Downloaded.AddSeconds(cacheControl);
            }
        }

        public DateTime LocalExpiration(TimeSpan localExpiration)
        {
            return Downloaded.Add(localExpiration);
        }
    }
}
