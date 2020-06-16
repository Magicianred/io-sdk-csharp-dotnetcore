using System;
using NUnit.Framework;
using io_sdk_csharp_dotnetcore;

namespace io_sdk_csharp_dotnetcore_test
{
    public class ImportsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void should_return_form_data()
        {
            var stringJson = Import.Process(null);

            Assert.IsTrue(stringJson.Contains("{ \"form\": "), "Form data deve essere valorizzato");
        }

        [Test]
        public void should_return_body_messages_data()
        {
            // correggere la connectionstring con i valori corretti del tuo database
            // var connectionString = "server=<your_bdHost>;user id=<your_bdUser>;password=<your_dbPass>;database=<your_dbName>;";

            var stringJson = Import.Process(connectionString);

            Assert.IsTrue(stringJson.Contains("{ \"body\": { \"data\": ["), "Body data deve essere valorizzato");
        }
    }
}