﻿using Empires.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empires.Game.GameWorld
{
    public class SolarSystem
    {
        public String name;

        public Boolean generated;

        public int ID;
        public int galaxy;

        public int distanceFromCentre;
        public Double position;

        public SolarSystem(Boolean generate, int galaxy)
        {
            this.ID = Objects.game.data.solarSystemCounter;
            Objects.game.data.solarSystemCounter++;
            this.galaxy = galaxy;

            Random rand = new Random();
            distanceFromCentre = rand.Next(10, 1000000);
            position = rand.NextDouble() * 360;

            Objects.game.data.bodies.Add(new Body(false, ID, Body.TYPE_STAR));

            if (generate)
            {
                int amountOfPlanets = rand.Next(3, 20);
                for (int i = 0; i < amountOfPlanets; i++)
                {
                    Objects.game.data.bodies.Add(new Body(false, ID, Body.TYPE_PLANET));
                }
            }
            else
            {
                generated = false;
            }
        }
    }
}
