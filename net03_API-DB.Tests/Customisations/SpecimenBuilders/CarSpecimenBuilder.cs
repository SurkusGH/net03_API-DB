using AutoFixture.Kernel;
using net03_API_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net03_API_DB.Tests.Customisations.SpecimenBuilders
{
    internal class CarSpecimenBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            if (request is Type type && type == typeof(Car))
            {
                return new Car { Id = Guid.NewGuid(), Color = "White", Model = "whatever" };
            }
            return null;
        }
    }
}
