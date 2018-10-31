using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CWapp.DataProvider
{
    public interface IDataProvider
    {
        Task<IEnumerable<Destination>> GetDestinations();


        Task<Destination> GetDestination(int DestinationId);


        Task AddDestination(Destination destination);


        Task DeleteDestination(int destinationId);


        Task UpdateDestination(int id, Destination destination);
    }

    public partial class Destination
    {
        [Key]
        public int DestinationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
