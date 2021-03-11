using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "Teste chuta \n";
        }

        public string Corre()
        {
            return "Teste Corre\n";
        }

        public string Passe()
        {
            return "Teste Passe\n";
        }
    }
}