using CleanArchitectureSolid.Entities.Interfaces;

namespace CleanArchitectureSolid.Entities.Entities
{
    public class Paloma : IAve
    {
        public string EmiteSonido()
        {
            return "La paloma arrulla.";
        }
    }
}
