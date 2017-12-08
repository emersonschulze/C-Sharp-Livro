﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MyLittleBees
{
    [Serializable]
    class Flower
    {
        //Constantes
        private const int LifeSpanMin = 15000;
        private const int LifeSpanMax = 30000;
        private const double InitialNectar = 1.5;
        private const double MaxNectar = 5.0;
        private const double NectarAddedPerTurn = 0.01;
        private const double NectarGatheredPerTurn = 0.3;

        //Propriedades
        public Point Location { get; private set; }

        public int Age { get; private set; }

        public bool Alive { get; private set; }

        public double Nectar { get; private set; }

        public double NectarHarvested { get; set; }

        private int lifeSpan;

        //Construtor
        public Flower(Point location, Random random)
        {
            Location = location;
            Age = 0;
            Alive = true;
            Nectar = InitialNectar;
            NectarHarvested = 0;
            lifeSpan = random.Next(LifeSpanMin, LifeSpanMax + 1);
        }

        public double HarvestNectar()
        {
            if (NectarGatheredPerTurn > Nectar)
                return 0;
            else
            {
                Nectar -= NectarGatheredPerTurn;
                NectarHarvested += NectarGatheredPerTurn;
                return NectarGatheredPerTurn;
            }
        }

        public void Go()
        {
            Age++;
            if (Age > lifeSpan)
                Alive = false;
            else
            {
                Nectar += NectarAddedPerTurn;
                if (Nectar > MaxNectar)
                    Nectar = MaxNectar;
            }
        }
    }
}
