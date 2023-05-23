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
        { }

        public override void Seed()
        {
            var countries = new Dictionary<string, Country>
                {
                    { "country.brazil", new Country { Id = IdGenerator.CreateId(), Name = "country.brazil" }},
                    { "country.india", new Country { Id = IdGenerator.CreateId(), Name = "country.india" }},
                    { "country.france", new Country { Id = IdGenerator.CreateId(), Name = "country.france" }},
                    { "country.south_korea", new Country { Id = IdGenerator.CreateId(), Name = "country.south_korea" }},
                    { "country.turkey", new Country { Id = IdGenerator.CreateId(), Name = "country.turkey" }},
                    { "country.china", new Country { Id = IdGenerator.CreateId(), Name = "country.china" }},
                    { "country.mexico", new Country { Id = IdGenerator.CreateId(), Name = "country.mexico" }},
                    { "country.united_states", new Country { Id = IdGenerator.CreateId(), Name = "country.united_states" }},
                    { "country.canada", new Country { Id = IdGenerator.CreateId(), Name = "country.canada" }},
                    { "country.germany", new Country { Id = IdGenerator.CreateId(), Name = "country.germany" }},
                    { "country.united_kingdom", new Country { Id = IdGenerator.CreateId(), Name = "country.united_kingdom" }},
                    { "country.italy", new Country { Id = IdGenerator.CreateId(), Name = "country.italy" }},
                };


            ModelBuilder.Entity<Country>().HasData(countries.Values.ToList());

            var cities = new Dictionary<string, City>
                {
                    { "city.brazil.sao_paulo", new City { Id = IdGenerator.CreateId(), Name = "city.brazil.sao_paulo", Timezone = "America/Sao_Paulo", CountryId = countries["country.brazil"].Id }},
                    { "city.turkey.istanbul", new City { Id = IdGenerator.CreateId(), Name = "city.turkey.istanbul", Timezone = "Europe/Istanbul", CountryId = countries["country.turkey"].Id }},
                    { "city.mexico.mexico_city", new City { Id = IdGenerator.CreateId(), Name = "city.mexico.mexico_city", Timezone = "America/Mexico_City", CountryId = countries["country.mexico"].Id }},
                    { "city.germany.berlin", new City { Id = IdGenerator.CreateId(), Name = "city.germany.berlin", Timezone = "Europe/Berlin", CountryId = countries["country.germany"].Id }},
                    { "city.italy.rome", new City { Id = IdGenerator.CreateId(), Name = "city.italy.rome", Timezone = "Europe/Rome", CountryId = countries["country.italy"].Id }},
                    { "city.united_kingdom.london", new City { Id = IdGenerator.CreateId(), Name = "city.united_kingdom.london", Timezone = "Europe/London", CountryId = countries["country.united_kingdom"].Id }},
                    { "city.canada.quebec", new City { Id = IdGenerator.CreateId(), Name = "city.canada.quebec", Timezone = "America/Toronto", CountryId = countries["country.canada"].Id }},
                    { "city.united_states.los_angeles", new City { Id = IdGenerator.CreateId(), Name = "city.united_states.los_angeles", Timezone = "America/Los_Angeles", CountryId = countries["country.united_states"].Id }},
                    { "city.china.beijing", new City { Id = IdGenerator.CreateId(), Name = "city.china.beijing", Timezone = "Asia/Shanghai", CountryId = countries["country.china"].Id }},
                    { "city.south_korea.seoul", new City { Id = IdGenerator.CreateId(), Name = "city.south_korea.seoul", Timezone = "Asia/Seoul", CountryId = countries["country.south_korea"].Id }},
                    { "city.france.cannes", new City { Id = IdGenerator.CreateId(), Name = "city.france.cannes", Timezone = "Europe/Paris", CountryId = countries["country.france"].Id }},
                    { "city.france.paris", new City { Id = IdGenerator.CreateId(), Name = "city.france.paris", Timezone = "Europe/Paris", CountryId = countries["country.france"].Id }},
                    { "city.india.mumbai", new City { Id = IdGenerator.CreateId(), Name = "city.india.mumbai", Timezone = "Asia/Kolkata", CountryId = countries["country.india"].Id }}
                };

            ModelBuilder.Entity<City>().HasData(cities.Values.ToList());

            var zones = new Dictionary<string, Zone>
                {
                    // Downtown zones
                    { "PracaDaSe", new Zone { Id = IdGenerator.CreateId(), Name = "Praça da Sé", Type = ZoneTypeEnum.Downtown, CityId = cities["SaoPaulo"].Id }},
                    { "Sultanahmet", new Zone { Id = IdGenerator.CreateId(), Name = "Sultanahmet", Type = ZoneTypeEnum.Downtown, CityId = cities["Istanbul"].Id }},
                    { "Cuauhtemoc", new Zone { Id = IdGenerator.CreateId(), Name = "Cuauhtémoc", Type = ZoneTypeEnum.Downtown, CityId = cities["MexicoCity"].Id }},
                    { "Mitte", new Zone { Id = IdGenerator.CreateId(), Name = "Mitte", Type = ZoneTypeEnum.Downtown, CityId = cities["Berlin"].Id }},
                    { "MunicipioI", new Zone { Id = IdGenerator.CreateId(), Name = "Municipio I", Type = ZoneTypeEnum.Downtown, CityId = cities["Rome"].Id }},
                    { "CityOfLondon", new Zone { Id = IdGenerator.CreateId(), Name = "City of London", Type = ZoneTypeEnum.Downtown, CityId = cities["London"].Id }},
                    { "VieuxQuebec", new Zone { Id = IdGenerator.CreateId(), Name = "Vieux Québec", Type = ZoneTypeEnum.Downtown, CityId = cities["Quebec"].Id }},
                    { "DowntownLA", new Zone { Id = IdGenerator.CreateId(), Name = "Downtown LA", Type = ZoneTypeEnum.Downtown, CityId = cities["LosAngeles"].Id }},
                    { "Dongcheng", new Zone { Id = IdGenerator.CreateId(), Name = "Dongcheng", Type = ZoneTypeEnum.Downtown, CityId = cities["Beijing"].Id }},
                    { "Jongno", new Zone { Id = IdGenerator.CreateId(), Name = "Jongno", Type = ZoneTypeEnum.Downtown, CityId = cities["Seoul"].Id }},
                    { "CannesCentre", new Zone { Id = IdGenerator.CreateId(), Name = "Centre Ville", Type = ZoneTypeEnum.Downtown, CityId = cities["Cannes"].Id }},
                    { "Paris1er", new Zone { Id = IdGenerator.CreateId(), Name = "1er arrondissement", Type = ZoneTypeEnum.Downtown, CityId = cities["Paris"].Id }},
                    { "SouthMumbai", new Zone { Id = IdGenerator.CreateId(), Name = "South Mumbai", Type = ZoneTypeEnum.Downtown, CityId = cities["Mumbai"].Id }},
                     // Residential zones
                    { "Higienopolis", new Zone { Id = IdGenerator.CreateId(), Name = "Higienópolis", Type = ZoneTypeEnum.Residential, CityId = cities["SaoPaulo"].Id }},
                    { "Bebek", new Zone { Id = IdGenerator.CreateId(), Name = "Bebek", Type = ZoneTypeEnum.Residential, CityId = cities["Istanbul"].Id }},
                    { "Polanco", new Zone { Id = IdGenerator.CreateId(), Name = "Polanco", Type = ZoneTypeEnum.Residential, CityId = cities["MexicoCity"].Id }},
                    { "Charlottenburg", new Zone { Id = IdGenerator.CreateId(), Name = "Charlottenburg", Type = ZoneTypeEnum.Residential, CityId = cities["Berlin"].Id }},
                    { "Trastevere", new Zone { Id = IdGenerator.CreateId(), Name = "Trastevere", Type = ZoneTypeEnum.Residential, CityId = cities["Rome"].Id }},
                    { "Kensington", new Zone { Id = IdGenerator.CreateId(), Name = "Kensington", Type = ZoneTypeEnum.Residential, CityId = cities["London"].Id }},
                    { "CapRouge", new Zone { Id = IdGenerator.CreateId(), Name = "Cap-Rouge", Type = ZoneTypeEnum.Residential, CityId = cities["Quebec"].Id }},
                    { "BeverlyHills", new Zone { Id = IdGenerator.CreateId(), Name = "Beverly Hills", Type = ZoneTypeEnum.Residential, CityId = cities["LosAngeles"].Id }},
                    { "Chaoyang", new Zone { Id = IdGenerator.CreateId(), Name = "Chaoyang", Type = ZoneTypeEnum.Residential, CityId = cities["Beijing"].Id }},
                    { "Gangnam", new Zone { Id = IdGenerator.CreateId(), Name = "Gangnam", Type = ZoneTypeEnum.Residential, CityId = cities["Seoul"].Id }},
                    { "LaBocca", new Zone { Id = IdGenerator.CreateId(), Name = "La Bocca", Type = ZoneTypeEnum.Residential, CityId = cities["Cannes"].Id }},
                    { "Montmartre", new Zone { Id = IdGenerator.CreateId(), Name = "Montmartre", Type = ZoneTypeEnum.Residential, CityId = cities["Paris"].Id }},
                    { "Bandra", new Zone { Id = IdGenerator.CreateId(), Name = "Bandra", Type = ZoneTypeEnum.Residential, CityId = cities["Mumbai"].Id }},
                    // Commercial zones
                    { "Paulista", new Zone { Id = IdGenerator.CreateId(), Name = "Avenida Paulista", Type = ZoneTypeEnum.Commercial, CityId = cities["SaoPaulo"].Id }},
                    { "Nisantasi", new Zone { Id = IdGenerator.CreateId(), Name = "Nişantaşı", Type = ZoneTypeEnum.Commercial, CityId = cities["Istanbul"].Id }},
                    { "ZonaRosa", new Zone { Id = IdGenerator.CreateId(), Name = "Zona Rosa", Type = ZoneTypeEnum.Commercial, CityId = cities["MexicoCity"].Id }},
                    { "PotsdamerPlatz", new Zone { Id = IdGenerator.CreateId(), Name = "Potsdamer Platz", Type = ZoneTypeEnum.Commercial, CityId = cities["Berlin"].Id }},
                    { "ViaDelCorso", new Zone { Id = IdGenerator.CreateId(), Name = "Via del Corso", Type = ZoneTypeEnum.Commercial, CityId = cities["Rome"].Id }},
                    { "Soho", new Zone { Id = IdGenerator.CreateId(), Name = "Soho", Type = ZoneTypeEnum.Commercial, CityId = cities["London"].Id }},
                    { "SaintRoch", new Zone { Id = IdGenerator.CreateId(), Name = "Saint-Roch", Type = ZoneTypeEnum.Commercial, CityId = cities["Quebec"].Id }},
                    { "Hollywood", new Zone { Id = IdGenerator.CreateId(), Name = "Hollywood", Type = ZoneTypeEnum.Commercial, CityId = cities["LosAngeles"].Id }},
                    { "Sanlitun", new Zone { Id = IdGenerator.CreateId(), Name = "Sanlitun", Type = ZoneTypeEnum.Commercial, CityId = cities["Beijing"].Id }},
                    { "Myeongdong", new Zone { Id = IdGenerator.CreateId(), Name = "Myeong-dong", Type = ZoneTypeEnum.Commercial, CityId = cities["Seoul"].Id }},
                    { "LaCroisette", new Zone { Id = IdGenerator.CreateId(), Name = "La Croisette", Type = ZoneTypeEnum.Commercial, CityId = cities["Cannes"].Id }},
                    { "ChampsElysees", new Zone { Id = IdGenerator.CreateId(), Name = "Champs-Élysées", Type = ZoneTypeEnum.Commercial, CityId = cities["Paris"].Id }},
                    { "Colaba", new Zone { Id = IdGenerator.CreateId(), Name = "Colaba", Type = ZoneTypeEnum.Commercial, CityId = cities["Mumbai"].Id }}


                };

            ModelBuilder.Entity<Zone>().HasData(zones.Values.ToList());

            var locations = new Dictionary<string, Location> {
                { "Prefeitura de São Paulo", new Location { Id = IdGenerator.CreateId(), Name = "Prefeitura de São Paulo", ZoneId = zones["Praça da Sé"].Id, LocationType = LocationTypeEnum.CityHall, Scoring = ScoringEnum.Good } }
            };

            ModelBuilder.Entity<Location>().HasData(locations.Values.ToList());
        }
    }
}
