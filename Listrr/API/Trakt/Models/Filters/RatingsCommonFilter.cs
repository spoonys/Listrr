﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Refit;

namespace Listrr.API.Trakt.Models.Filters
{
    public class RatingsCommonFilter
    {
        public RatingsCommonFilter()
        {
            
        }

        public RatingsCommonFilter(string rating)
        {
            if (rating.Contains("-"))
            {
                From = Convert.ToInt32(rating.Split("-")[0]);
                To = Convert.ToInt32(rating.Split("-")[1]);
            }
            else
            {
                From = 0; 
                To = Convert.ToInt32(rating);
            }
        }

        [Range(0,10)]
        [Display(Name = "Min rating", Prompt = "0")]
        public int From { get; set; } = 0;

        [Range(0,10)]
        [Display(Name = "Max rating", Prompt = "10")]
        public int To { get; set; } = 0;

    }
}