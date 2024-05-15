using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Models
{
    public class Dice
    {
        public int QuantidadeLados { get; set; }

        public int NumeroSorteado { get; set; }

        public Dice(int qtsLados) {
            QuantidadeLados = qtsLados;
        }

        public void Rolar()
        {
            NumeroSorteado = new Random().Next(1, QuantidadeLados + 1);
        }
    }
}
