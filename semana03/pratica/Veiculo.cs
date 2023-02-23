using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica
{
    public class Veiculo
    {
        public int ID { get; set; }
        public string Cor { get; set; }
        public float KM { get; set; }
        public float Velociade { get; set; }
        public string TipoVeiculo { get; set; }

        public Veiculo(int id, string cor, float km, float velocidade, string tipoVeiculo)
        {
            this.ID = id;
            this.Cor = cor;
            this.KM = km;
            this.Velociade = velocidade;
            this.TipoVeiculo = tipoVeiculo;
        }

        public void Acelerar(float velocidade)
        {
            Velociade+= velocidade;
            Console.WriteLine(Velociade);
        }
        public void Parar()
        {
            Velociade = 0;
            Console.WriteLine(Velociade);
        }
        public void ImprimirVeiculo()
        {
            Console.WriteLine("ID: {0} Cor: {1} KM: {2} Velocidade: {3} Tipo do Veículo: {4}", ID, Cor, KM, Velociade, TipoVeiculo);
        }
    }
}
