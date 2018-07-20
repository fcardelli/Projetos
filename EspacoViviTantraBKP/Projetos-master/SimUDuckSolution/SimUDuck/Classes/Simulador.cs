using SimUDuck.Interfaces;
namespace SimUDuck.Classes
{
    public class Simulador
    {
        public void Executar(IPato pato)
        {
            pato.Grasnar();
            pato.Nadar();
            pato.Voar();
        }

    }

}