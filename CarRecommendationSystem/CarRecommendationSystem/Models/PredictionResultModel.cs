using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRecommendationSystem.Models
{
    public class PredictionResultModel
    {
        public string Name { get; set; }
        public decimal Confidence { get; set; }
    }
}
