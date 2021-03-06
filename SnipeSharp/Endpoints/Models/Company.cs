﻿using SnipeSharp.Common;
using Newtonsoft.Json;

namespace SnipeSharp.Endpoints.Models
{
    public class Company : CommonEndpointModel
    {
        public Company(string name)
        {
            this.Name = name;
        }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("assets_count")]
        public long? AssetsCount { get; set; }

        [JsonProperty("licenses_count")]
        public long? LicensesCount { get; set; }

        [JsonProperty("accessories_count")]
        public long? AccessoriesCount { get; set; }

        [JsonProperty("consumables_count")]
        public long? ConsumablesCount { get; set; }

        [JsonProperty("components_count")]
        public long? ComponentsCount { get; set; }

        [JsonProperty("users_count")]
        public long? UsersCount { get; set; }
    }
}
