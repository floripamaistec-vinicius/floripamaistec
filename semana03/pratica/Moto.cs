using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pratica;

namespace pratica
{
    public class Moto : Veiculo
    {
        public bool Bau { get; set; }
        public bool AntenaLinhaPipa { get; set; }
        public bool Capacete { get; set; }
        public Moto(int id, string cor, float km, float velocidade, string tipoVeiculo, bool bau, bool antenaLinhaPipa, bool capacete) : base(id, cor, km, velocidade, tipoVeiculo)
        {
            this.Bau = bau;
            this.AntenaLinhaPipa = antenaLinhaPipa;
            this.Capacete = capacete;
        }
        public void PilotoComCapacete()
        {
            Console.WriteLine();
        }
        public void CapaChuva()
        {
            Console.WriteLine();
        }
    }
}
