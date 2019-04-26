using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TP_Math
{
    class Probabilité
    {

        private double Écartype_, Moyenne_, ValeurA_, ValeurB_, CodeZ_, CodeZ2_;

        Probabilité(double ValeurA, double Moyenne, double ÉcartType)
        {
            Écartype_ = ÉcartType;
            Moyenne_ = Moyenne;
            ValeurA_ = ValeurA;
            CodeZ_ = CalculerZ(ValeurA_);
        }

        Probabilité(double ValeurA, double ValeurB, double Moyenne, double ÉcartType)
        {
            Écartype_ = ÉcartType;
            Moyenne_ = Moyenne;
            ValeurA_ = ValeurA;
            ValeurB_ = ValeurB;
            CodeZ_ = CalculerZ(ValeurA_);
            CodeZ2_ = CalculerZ(ValeurB_);
        }

        private double CalculerZ(double Valeur)
        {
            return (Valeur - Moyenne_) / Écartype_;
        }

    }
}