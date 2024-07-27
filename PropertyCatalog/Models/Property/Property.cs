using Microsoft.AspNetCore.Identity;

namespace PropertyCatalog.Models.Property
{
    public class Property
    {

        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Size { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string GetFormattedBasePrice() => Price.ToString("0.00");
        /*
          Solar en Venta Frente al Parque Mirador Norte.

           Son 2,207 m2

           Precio Por metro RD$ 16,000 Pesos.

           Bien ubicado y con su titulo.
        */
    }
}
