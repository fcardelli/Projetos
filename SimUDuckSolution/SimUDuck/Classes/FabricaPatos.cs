

using System.Collections.Generic;
using SimUDuck.Interfaces;

namespace SimUDuck.Classes
{
    public class FabricaPatos
    {
        public List<IPato> ObterPatos()
        {
            //List<IPato>
            List<IPato> patos = new List<IPato>();
            patos.Add(new PatoSelvagem());
            patos.Add(new PatoCabecaVermelha());
            patos.Add(new PatoReal());

            return patos;
        }

}