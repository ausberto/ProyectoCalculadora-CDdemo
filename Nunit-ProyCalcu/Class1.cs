using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Nunit_ProyCalcu
{
  [TestFixture]
  public class Class1
  {
    [Test]
    public void Multi()
    {
      var objResp = new ProyectoCalculadora.Controllers.Operaciones();
      Assert.AreEqual(0, objResp.Multiplicacion(1,0));
    }

    [Test]
    public void Multi2()
    {
      var objResp = new ProyectoCalculadora.Controllers.Operaciones();
      Assert.AreEqual(56, objResp.Multiplicacion(7,8));
    }
  }
}
