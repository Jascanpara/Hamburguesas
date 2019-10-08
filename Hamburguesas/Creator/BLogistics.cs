using Hamburguesas.Models;

namespace Hamburguesas.Creator
{
    class BLogistics : Logistics
    {
        public override IFood CreateTransport()
        {
            return new Baguette();
        }
    }
}
