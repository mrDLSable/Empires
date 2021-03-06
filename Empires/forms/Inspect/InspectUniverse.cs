﻿using Empires.Game.GameWorld;
using Empires.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Empires.forms
{
    public partial class InspectUniverse : Form
    {
        public int universe = 0;

        public InspectUniverse(int universe)
        {
            this.universe = universe;
            InitializeComponent();
        }

        private void InspectUniverse_Load(object sender, EventArgs e)
        {
            this.tb_UniverseName.Text = Objects.game.data.universes[universe].name;

            int galaxies = 0;
            int solarSystems = 0;
            int bodies = 0;
            int stars = 0;
            int planets = 0;
            int asteroids = 0;

            foreach (Galaxy galaxy in Objects.game.data.galaxies)
            {
                if (galaxy.universe == universe)
                {
                    galaxies++;
                }
            }

            foreach (SolarSystem solarSystem in Objects.game.data.solarSystems)
            {
                if (Objects.game.data.galaxies[solarSystem.galaxy].universe == universe)
                {
                    solarSystems++;
                }
            }

            foreach (Body body in Objects.game.data.bodies)
            {
                if (Objects.game.data.galaxies[Objects.game.data.solarSystems[body.solarSystem].galaxy].universe == universe)
                {
                    bodies++;
                    switch (body.type)
                    {
                        case Body.TYPE_STAR:
                            stars++;
                            break;
                        case Body.TYPE_PLANET:
                            planets++;
                            break;
                        case Body.TYPE_ASTROID:
                            asteroids++;
                            break;
                    }
                }
            }

            this.lbl_GalaxiesAmount.Text = galaxies.ToString();
            this.lbl_SolarSystemsAmount.Text = solarSystems.ToString();
            this.lbl_BodiesAmount.Text = bodies.ToString();
            this.lbl_StarsAmount.Text = stars.ToString();
            this.lbl_PlanetsAmount.Text = planets.ToString();
            this.lbl_AsteroidsAmount.Text = asteroids.ToString();
        }

        private void btn_Galaxies_Click(object sender, EventArgs e)
        {
            GalaxyList galaxyList = new GalaxyList();
            galaxyList.Show();
            galaxyList.setUniverse(this.universe);
        }

        private void btn_SolarSystems_Click(object sender, EventArgs e)
        {
            SolarSystemList solarSystemList = new SolarSystemList();
            solarSystemList.Show();
            solarSystemList.setUniverse(this.universe);
        }

        private void btn_ViewMap_Click(object sender, EventArgs e)
        {
            UniverseMap universeMap = new UniverseMap();
            universeMap.Show();
            universeMap.setUniverse(this.universe);
        }

        private void btn_Bodies_Click(object sender, EventArgs e)
        {
            BodiesList bodiesList = new BodiesList();
            bodiesList.Show();
            bodiesList.setUniverse(this.universe);
        }
    }
}
