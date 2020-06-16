using NUnit.Framework;
using io_sdk_csharp_dotnetcore;

namespace io_sdk_csharp_dotnetcore_test
{
    public class RepositoryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void should_return_error_message()
        {
            // lasciare la connection string errata
            var data = Repository.GetMessages("server=<your_bdHost>;user id=<your_bdUser>;password=<your_dbPass>;database=<your_dbName>;");

            Assert.IsNotNull(data, "Data deve essere valorizzato");
            Assert.IsNull(data.Messages, "I Messaggi non devono essere presenti");
            Assert.IsNotNull(data.Error, "Data.Error deve essere valorizzato");
        }

        [Test]
        public void should_return_messages()
        {
            // correggere la connectionstring con i valori corretti del tuo database
            var data = Repository.GetMessages("server=<your_bdHost>;user id=<your_bdUser>;password=<your_dbPass>;database=<your_dbName>;");

            Assert.IsNotNull(data, "Data deve essere valorizzato");
            Assert.IsNull(data.Error, $"Data.Error deve essere Null: {data.Error}");
            Assert.IsNotNull(data.Messages, "I Messaggi devono essere presenti");
            Assert.IsTrue(data.Messages.Count > 0, "I Messaggi devono essere presenti");
        }
    }
}