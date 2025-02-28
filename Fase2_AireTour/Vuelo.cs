using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase2_AireTour
{
    internal class Vuelo
    {
        public long id { get; set; }
        public string name { get; set; }
        public string des { get; set; }
        public enum Cla
        {
            A, B, C
        }
        public Cla cla { get; set; }
        public enum Dia
        {
            Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo
        }
        public Dia dia { get; set; }
        public enum Gen
        {
            Masculino, Femenino
        }
        public Gen gen { get; set; }
        public int est { get; set; }
        public double val { get; set; }

        double valBruto;
        double desEst;
        double desDia;
        double desGen;

        public double getValBruto()
        {
            valBruto = 0;

            if (des == "Bogotá")
            {
                if (cla == Cla.A)
                    valBruto = 300000;
                else if (cla == Cla.B)
                    valBruto = 225000;
                else if (cla == Cla.C)
                    valBruto = 150000;
                else
                    valBruto = 0;
            }
            else if (des == "Medellín")
            {
                if (cla == Cla.A)
                    valBruto = 420000;
                else if (cla == Cla.B)
                    valBruto = 315000;
                else if (cla == Cla.C)
                    valBruto = 210000;
                else
                    valBruto = 0;
            }
            else if (des == "Florencia")
            {
                if (cla == Cla.A)
                    valBruto = 270000;
                else if (cla == Cla.B)
                    valBruto = 202500;
                else if (cla == Cla.C)
                    valBruto = 135000;
                else
                    valBruto = 0;
            }
            else if (des == "Pitalito")
            {
                if (cla == Cla.A)
                    valBruto = 250000;
                else if (cla == Cla.B)
                    valBruto = 187500;
                else if (cla == Cla.C)
                    valBruto = 125000;
                else
                    valBruto = 0;
            }

            return valBruto;
        }

        public double getDesEst()
        {
            desEst = 0;

            switch (est)
            {
                case 1:
                    desEst = valBruto * 0.1;
                    break;
                case 2:
                    desEst = valBruto * 0.1;
                    break;
                case 3:
                    desEst = valBruto * 0.07;
                    break;
                case 4:
                    desEst = valBruto * 0.07;
                    break;
                case 5:
                    desEst = valBruto * 0.05;
                    break;
                case 6:
                    desEst = valBruto * 0.05;
                    break;
            }

            return desEst;
        }

        public double getDesDia()
        {
            desDia = 0;

            switch (dia)
            {
                case Dia.Lunes:
                    desDia = valBruto * 0.1;
                    break;
                case Dia.Martes:
                    desDia = valBruto * 0.1;
                    break;
                case Dia.Miercoles:
                    desDia = valBruto * 0.1;
                    break;
                case Dia.Jueves:
                    desDia = valBruto * 0.05;
                    break;
                case Dia.Viernes:
                    desDia = valBruto * 0.05;
                    break;
                case Dia.Sabado:
                    desDia = 0;
                    break;
                case Dia.Domingo:
                    desDia = 0;
                    break;
            }

            return desDia;
        }

        public double getDesGen()
        {
            desGen = 0;

            if (gen == Gen.Femenino)
            {
                desGen = valBruto * 0.03;
            }
            else if (gen == Gen.Masculino)
            {
                desGen = 0;
            }

            return desGen;
        }

        public double getValDes()
        {
            return getDesDia() + getDesEst() + getDesGen();
        }

        public double getValTotal()
        {
            return getValBruto() - getValDes();
        }
    }
}
