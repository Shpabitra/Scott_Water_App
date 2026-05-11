using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scott_Water_App
{
    public class Price
    {
        // Attributes
        private double lowTier1Rate;
        private double lowTier2Rate;
        private double lowTier3Rate;
        private double tier1Rate;
        private double tier2Rate;
        private double tier3Rate;
        private double recycleRate1;
        private double recycleRate2;
        private double recycleRate3;

        public static Price Current { get; private set; }

        // default file name placed in output directory (set Prices.txt to Copy to Output Directory)
        private static readonly string PricesFilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Prices.txt");

        // properties
        public double LowTier1Rate 
        { 
            get { return lowTier1Rate; }
            set { lowTier1Rate = value; }
        }
        public double LowTier2Rate 
        { 
            get { return lowTier2Rate; } 
            set { lowTier2Rate = value; }
        }
        public double LowTier3Rate 
        { 
            get { return lowTier3Rate; } 
            set { lowTier3Rate = value; } 
        }
        public double Tier1Rate 
        { 
            get { return tier1Rate; }
            set { tier1Rate = value; }
        }
        public double Tier2Rate 
        { 
            get { return tier2Rate; } 
            set { tier2Rate = value; }
        }
        public double Tier3Rate 
        { 
            get { return tier3Rate; } 
            set { tier3Rate = value; }
        }
        public double RecycleRate1 
        { 
            get { return recycleRate1; }
            set { recycleRate1 = value; }
        }
        public double RecycleRate2 
        { 
            get { return recycleRate2; }
            set { recycleRate2 = value; }
        }
        public double RecycleRate3 
        { 
            get { return recycleRate3; } 
            set { recycleRate3 = value; }
        }

        // defaults 
        public Price()
        {
            // Low-reserve (higher) rates
            LowTier1Rate = 0.47;
            LowTier2Rate = 0.82;
            LowTier3Rate = 2.25;

            // Standard (lower) rates
            Tier1Rate = 0.41;
            Tier2Rate = 0.64;
            Tier3Rate = 1.35;

            // recycling credit tiers
            RecycleRate1 = 0.05;
            RecycleRate2 = 0.15;
            RecycleRate3 = 0.25;
        }

        // Load current prices from Prices.txt if present, otherwise use defaults
        static Price()
        {
            Current = new Price();
            try
            {
                if (File.Exists(PricesFilePath))
                {
                    Current.LoadFromFile(PricesFilePath);
                }
            }
            catch
            {
                //keep defaults if load fails
            }
        }

        public void SaveToFile(string filePath = null)
        {
            try
            {
                var path = filePath ?? PricesFilePath;
                var lines = new List<string>
                {
                    $"LowTier1Rate={LowTier1Rate.ToString(CultureInfo.InvariantCulture)}",
                    $"LowTier2Rate={LowTier2Rate.ToString(CultureInfo.InvariantCulture)}",
                    $"LowTier3Rate={LowTier3Rate.ToString(CultureInfo.InvariantCulture)}",
                    $"Tier1Rate={Tier1Rate.ToString(CultureInfo.InvariantCulture)}",
                    $"Tier2Rate={Tier2Rate.ToString(CultureInfo.InvariantCulture)}",
                    $"Tier3Rate={Tier3Rate.ToString(CultureInfo.InvariantCulture)}",
                    $"RecycleRate1={RecycleRate1.ToString(CultureInfo.InvariantCulture)}",
                    $"RecycleRate2={RecycleRate2.ToString(CultureInfo.InvariantCulture)}",
                    $"RecycleRate3={RecycleRate3.ToString(CultureInfo.InvariantCulture)}"
                };
                File.WriteAllLines(path, lines, Encoding.UTF8);
            }
            catch
            {
                // ignore write errors for now
            }
        }

        public void LoadFromFile(string filePath)
        {
            var text = File.ReadAllLines(filePath);
            foreach (var line in text)
            {
                if (string.IsNullOrWhiteSpace(line) || !line.Contains("=")) continue;
                var parts = line.Split(new[] { '=' }, 2);
                var key = parts[0].Trim();
                var val = parts[1].Trim();
                double d;
                if (!double.TryParse(val, NumberStyles.Any, CultureInfo.InvariantCulture, out d)) continue;
                switch (key)
                {
                    case "LowTier1Rate": LowTier1Rate = d; break;
                    case "LowTier2Rate": LowTier2Rate = d; break;
                    case "LowTier3Rate": LowTier3Rate = d; break;
                    case "Tier1Rate": Tier1Rate = d; break;
                    case "Tier2Rate": Tier2Rate = d; break;
                    case "Tier3Rate": Tier3Rate = d; break;
                    case "RecycleRate1": RecycleRate1 = d; break;
                    case "RecycleRate2": RecycleRate2 = d; break;
                    case "RecycleRate3": RecycleRate3 = d; break;
                }
            }
        }
    }
}
