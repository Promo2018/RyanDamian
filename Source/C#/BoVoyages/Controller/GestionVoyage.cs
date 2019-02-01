﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoVoyages.Model;

namespace BoVoyages.Controller
{
    public class GestionVoyage
    {
        private List<string> voyages = new List<string>();

        public GestionVoyage()
        {
            //voyages = Voyage.getVoyages().ToList();
        }

        public void listVoyages()
        {
            foreach (string line in voyages)
            {
                System.Console.WriteLine(line);
            }
        }

        public void ajouterVoyages()
        {
            System.Console.WriteLine(">>>>>>>>>>   PAS ENCORE IMPLEMENTE !");
        }

        public void enregistrer()
        {
            //Voyage.setVoyages(voyages.ToArray());
        }

        public void deleteVoyagesPerimes()
        {
            Model.Voyage voyage = new Model.Voyage();
            voyage.deleteVoyagesPerimes();
        }

        private DateTime getDateDebut(string line)
        {
            DateTime dateDebut;
            string[] values = line.Split(',');
            dateDebut = DateTime.Parse(values[2]);
            return dateDebut;
        }
    }
}
