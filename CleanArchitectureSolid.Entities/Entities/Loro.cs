using CleanArchitectureSolid.Entities.Interfaces;

namespace CleanArchitectureSolid.Entities.Entities
{
    public class Loro : IAve
    {
        public string EmiteSonido()
        {
            return "El Loro garre.";
        }
    }
}
