using Encapsulamento;

Pessoa.cs 
namespace Encapsulamento
{
    internal class Pessoa
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
            }
        }
    }
}
