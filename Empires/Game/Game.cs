﻿using Empires.Game.GameWorld;
using Empires.IO.Packages;
using Empires.IO.Packages.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Empires.Game
{
    public class Game
    {
        public GameData data;

        private String path;

        public Game()
        {
            this.data = new GameData();
            this.path = "";
        }

        public Game(String path)
        {
            data = new GameData();
            this.path = path;
        }

        public void save()
        {
            String json = JsonConvert.SerializeObject(data, Formatting.Indented);

            if (path == "")
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Empires\\saves\\" + data.name + ".esav";
            }

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (FileStream fs = File.Create(path))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(json);
                fs.Write(info, 0, info.Length);
            }
        }

        public void load()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                String json = "";
                json = sr.ReadToEnd();
                data = JsonConvert.DeserializeObject<GameData>(json);
            }

            onePackage();
        }

        public void onePackage()
        {
            data.package = new Package();
            foreach (Package package in data.packages)
            {
                foreach (Material material in package.data.materials)
                {
                    data.package.data.materials.Add(material);
                }

                foreach (String objectName in package.data.objectNames)
                {
                    data.package.data.objectNames.Add(objectName);
                }
            }
        }

        public void generate()
        {
            data.universes = new List<Universe>();
            data.galaxies = new List<Galaxy>();
            data.solarSystems = new List<SolarSystem>();
            data.bodies = new List<Body>();
            data.universes.Add(new Universe());
        }
    }
}
