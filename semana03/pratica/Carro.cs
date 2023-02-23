using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pratica;

namespace pratica
{
    public class Carro : Veiculo
    {
        public bool AirBag { get; set; }
        public bool Radio { get; set; }
        public bool CameraRe { get; set; }
        public Carro(int id, string cor, float km, float velocidade, string tipoVeiculo, bool airBag, bool radio, bool cameraRe) : base(id, cor, km, velocidade, tipoVeiculo)
        {
            this.AirBag = airBag;
            this.Radio = radio;
            this.CameraRe = cameraRe;
        }

    }
}
