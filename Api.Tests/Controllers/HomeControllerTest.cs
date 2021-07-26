using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Api;
using Api.Controllers;
using System.Collections.Generic;
using System.Collections;

namespace Api.Tests.Controllers
{
    [TestClass]
    public class SecretControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Disponer
            TopSecretController controller = new TopSecretController();

            // Actuar
            var input = new List<Api.Models.Satelites>();
            input.Add(new Models.Satelites { Distance = 100.0, Name = "kenobi", Message = new string[] { "este", "es", "", "", "mensaje" } });
            input.Add(new Models.Satelites { Distance = 115.5, Name = "skywalker", Message = new string[] { "","es", "","","secreto" } });
            input.Add(new Models.Satelites { Distance = 142.7, Name = "soto", Message = new string[] { "este", "", "un", "", "" } });
            IEnumerable<Api.Models.Satelites> satelites = input as IEnumerable<Api.Models.Satelites>;
            var result = controller.TopSecret(satelites);

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            
        }
    }
}
