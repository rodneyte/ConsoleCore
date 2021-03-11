using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;

        public JogoFODA(IJogador jogador1,IJogador jogador2)
        {
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Passe());

            System.Console.WriteLine("\nProximo jogador\n");

            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passe());
        }
    }
}