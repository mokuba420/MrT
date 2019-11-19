using MRTshirtAPi.Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MRTshirtAPi.Api.Modles;

namespace MRTshirtAPi.Data
{
    public class SeedData
    {


        public static void Initialize(information context)
        {
            if (!context.TShirttable.Any())
            {
                context.TShirttable.AddRange(
                    new TShirttable
                    {
                       
                        Name = "max",
                        Size = "large",
                        ShippingAddress = "cat fire road"
                    }

                    );

                 context.SaveChanges();
            }
        }
    }
}
