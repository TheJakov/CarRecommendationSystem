using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRecommendationSystem.Models
{
    /// <summary>
    /// Class mapping the car records from dataset
    /// </summary>
    public class CSVCarModel
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

        // Score attributes

        public int OverallScore { get; set; }
        public int DrivingScore { get; set; }
        public int ComfortScore { get; set; }
        public int InteriorScore { get; set; }
        public int TechnologyScore { get; set; }
        public int StorageScore { get; set; }
        public int EconomicalScore { get; set; }
        public int GoodValueScore { get; set; }

        // Additional attributes

        public int Litres100km { get; set; }
        public int Seats { get; set; }
        public string Transmission { get; set; }
        public int Horsepower { get; set; }
        public string FuelType { get; set; }

        /// <summary>
        /// Score is calculated in EvalutationHelper class as result of car evaluation
        /// based on user preferences
        /// </summary>
        public int Score { get; set; }
    }
}
