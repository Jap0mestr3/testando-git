﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeAbstract
{
    class Retangulo : Figura
    {
        public double largura { get; set; }
        public double altura { get; set; }

        public Retangulo(double largura, double altura, string cor) : base(cor) 
        {
            this.largura = largura;
            this.altura = altura;
        }

        public override double area()
        {
            return largura * altura;
        }
        public override double perimetro()
        {
            return 2 * (largura + altura);
        }
    }
}
