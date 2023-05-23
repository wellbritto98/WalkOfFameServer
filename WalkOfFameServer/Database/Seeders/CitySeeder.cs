using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using IdGen;
using Microsoft.EntityFrameworkCore;
using WalkOfFameServer.Database.Seeds;
using WalkOfFameServer.Enums;
using WalkOfFameServer.Models.Cities;

namespace WalkOfFameServer.Database.Seeders
{
    public class CitySeeder : BaseSeeder
    {
        public CitySeeder(ModelBuilder modelBuilder, IdGenerator idGenerator) : base(modelBuilder, idGenerator)
        {}

        public override void Seed()
        {
            var countries = new Dictionary<string, Country> {
                { "Brazil", new Country { Id = IdGenerator.CreateId(), Name = "Brazil" } }
            };

            ModelBuilder.Entity<Country>().HasData(countries.Values.ToList());

            var cities = new Dictionary<string, City> {
                { "São Paulo", new City { Id = IdGenerator.CreateId(), Name = "São Paulo", Timezone = "America/Sao_Paulo", CountryId = countries["Brazil"].Id } }
            };
            
            ModelBuilder.Entity<City>().HasData(cities.Values.ToList());

            var zones = new Dictionary<string, Zone> {
                { "Praça da Sé", new Zone { Id = IdGenerator.CreateId(), Name = "Praça da Sé", Type = ZoneTypeEnum.Downtown, CityId = cities["São Paulo"].Id } }
            };
            
            ModelBuilder.Entity<Zone>().HasData(zones.Values.ToList());

            var locations = new Dictionary<string, Location> {
                { "Prefeitura de São Paulo", new Location { Id = IdGenerator.CreateId(), Name = "Prefeitura de São Paulo", ZoneId = zones["Praça da Sé"].Id, LocationType = LocationTypeEnum.CityHall, Scoring = ScoringEnum.Good } }
            };
            
            ModelBuilder.Entity<Location>().HasData(locations.Values.ToList());
        }
    }
}
