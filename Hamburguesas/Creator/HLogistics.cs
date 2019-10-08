using Hamburguesas.Models;
using Hamburguesas.Builders;

namespace Hamburguesas.Creator
{
    class HLogistics : Logistics
    {
        public override IFood CreateTransport()
        {
            return new Hamburguesa();
        }
    }
}
