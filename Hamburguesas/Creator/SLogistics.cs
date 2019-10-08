using Hamburguesas.Models;

namespace Hamburguesas.Creator
{
    class SLogistics : Logistics
    {
        public override IFood CreateTransport()
        {
            return new Sandwish();
        }
    }
}
