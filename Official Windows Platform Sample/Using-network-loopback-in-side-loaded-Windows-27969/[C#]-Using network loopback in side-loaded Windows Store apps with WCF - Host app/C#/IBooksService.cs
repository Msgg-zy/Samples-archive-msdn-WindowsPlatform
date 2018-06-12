using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceHost
{
    [ServiceContract]
    public interface IBooksService
    {
        [OperationContract]
        Book GetBookById(string id);

        [OperationContract]
        IEnumerable<string> GetGenres();

        [OperationContract]
        IEnumerable<Book> GetBooksByGenre(string genre);
    }
}
