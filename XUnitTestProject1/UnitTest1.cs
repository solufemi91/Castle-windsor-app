using CWapp.DataProvider;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;
using System.Collections;
using System.Linq;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetDestinations()
        {
            var destinations = new List<Destination>
            {
               new Destination
               {
                   DestinationId = 1,
                   Country = "DefaultPassword",
                   City = "London"
               },

               new Destination
               {
                   DestinationId = 2 ,
                   Country = "DefaultPassword",
                   City = "London"
               }
            };

         

            var mock = new Mock<IDataProvider>();
            mock.Setup(x => x.GetDestinations()).ReturnsAsync(destinations.AsEnumerable());

          
        }
    }
}
