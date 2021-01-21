﻿using System;
namespace BookByIdApi.Configurations
{
    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string Secret { get; set; }
        public int Minutes { get; set; }
        public int DaysToExpire { get; set; }

        public TokenConfigurations()
        {

        }

    }
}
