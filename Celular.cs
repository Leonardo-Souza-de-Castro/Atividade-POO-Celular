namespace Exercicio_POO_Celular
{
    public class Celular
    {
        public string modelo;

        public string cor;

        public double tamanho;

        public bool ligado;
        
        public bool ligar(){
            ligado = true;
            return ligado;
        }
        public bool desligar(){
            ligado = false;
            return ligado;
        }

        public string ligacao(){
            return "Você esta sem créditos no momento, recarregue e tente novamente";
        }

        public string mensagem(){
            string mensagem = "enviando";
            return mensagem;
        }
    }
}