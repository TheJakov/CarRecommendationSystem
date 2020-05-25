﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRecommendationSystem.Models
{
    static class EvaluationModel
    {
        // Not considered in any model making predictions
        public static int ID = 0;

        public static int? Year;

        public static int? Price;

        public static int OverallScoreCoef = 1;
        public static int? DrivingScoreCoef;
        public static int? ComfortScoreCoef;
        public static int? InteriorScoreCoef;
        public static int? TechnologyScoreCoef;
        public static int? StorageScoreCoef;
        public static int? EconomicalScoreCoef;
        public static int? GoodValueScoreCoef;

        public static string FuelEfficiency;

        public static int? Seats;

        public static string Transmission;

        public static int? Horsepower;

        public static string FuelType;
    }
}
