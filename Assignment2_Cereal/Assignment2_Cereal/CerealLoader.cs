﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2_Cereal
{
    class CerealLoader
    {
        public List<Cereal> allCereals = new List<Cereal>();
        public string[] identifiers;
        public void ReadCSV()
        {
            Console.WriteLine("READING");
            // Creates a StreamReader to read the csv file
            StreamReader reader = new StreamReader("cereal.csv");
            try
            {   
                // used to get the forst row of Identifiers
                string readID = reader.ReadLine();
                identifiers = readID.Split(',');

                // A variable to store an entire string of data
                string csvValues;
                // Will loop through the csv until all data is read
                while ((csvValues = reader.ReadLine()) != null)
                {
                    // splits the string of data using the Split method
                    // then stores it in an array of values
                    string[] values = csvValues.Split(',');
                    // pass that array to parsed
                    CreateCereal(values);
                }

                Console.WriteLine(allCereals.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Takes in an array of strings and parses it accordingly
        /// NEED TO KNOW WHAT EACH VALUE NEEDS TO BE PRIOR TO DOING
        /// </summary>
        /// <param name="values"></param>
        public void CreateCereal(string[] values)
        {
            // Creates a newCereal based on the parsing of the csv data
            Cereal newCereal = new Cereal(values[0], char.Parse(values[1]), char.Parse(values[2]),
                int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5]), int.Parse(values[6]),
                float.Parse(values[7]), float.Parse(values[8]), int.Parse(values[9]), int.Parse(values[10]),
                int.Parse(values[11]), int.Parse(values[12]), float.Parse(values[13]), float.Parse(values[14]),
                double.Parse(values[15]));

            // Adds this new cereal to a list of cereals
            allCereals.Add(newCereal);
        }
    }


}

