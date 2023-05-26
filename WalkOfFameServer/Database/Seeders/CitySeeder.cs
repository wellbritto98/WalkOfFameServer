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
                    { "zone.brazil.sao_paulo.praca_da_se", new Zone { Id = IdGenerator.CreateId(), Name = "zone.brazil.sao_paulo.praca_da_se", Type = ZoneTypeEnum.Downtown, CityId = cities["city.brazil.sao_paulo"].Id }},
                    { "zone.turkey.istanbul.sultanahmet", new Zone { Id = IdGenerator.CreateId(), Name = "zone.turkey.istanbul.sultanahmet", Type = ZoneTypeEnum.Downtown, CityId = cities["city.turkey.istanbul"].Id }},
                    { "zone.mexico.mexico_city.cuauhtemoc", new Zone { Id = IdGenerator.CreateId(), Name = "zone.mexico.mexico_city.cuauhtemoc", Type = ZoneTypeEnum.Downtown, CityId = cities["city.mexico.mexico_city"].Id }},
                    { "zone.germany.berlin.mitte", new Zone { Id = IdGenerator.CreateId(), Name = "zone.germany.berlin.mitte", Type = ZoneTypeEnum.Downtown, CityId = cities["city.germany.berlin"].Id }},
                    { "zone.italy.rome.municipio_i", new Zone { Id = IdGenerator.CreateId(), Name = "zone.italy.rome.municipio_i", Type = ZoneTypeEnum.Downtown, CityId = cities["city.italy.rome"].Id }},
                    { "zone.united_kingdom.london.city_of_london", new Zone { Id = IdGenerator.CreateId(), Name = "zone.united_kingdom.london.city_of_london", Type = ZoneTypeEnum.Downtown, CityId = cities["city.united_kingdom.london"].Id }},
                    { "zone.canada.quebec.vieux_quebec", new Zone { Id = IdGenerator.CreateId(), Name = "zone.canada.quebec.vieux_quebec", Type = ZoneTypeEnum.Downtown, CityId = cities["city.canada.quebec"].Id }},
                    { "zone.united_states.los_angeles.downtown_la", new Zone { Id = IdGenerator.CreateId(), Name = "zone.united_states.los_angeles.downtown_la", Type = ZoneTypeEnum.Downtown, CityId = cities["city.united_states.los_angeles"].Id }},
                    { "zone.china.beijing.dongcheng", new Zone { Id = IdGenerator.CreateId(), Name = "zone.china.beijing.dongcheng", Type = ZoneTypeEnum.Downtown, CityId = cities["city.china.beijing"].Id }},
                    { "zone.south_korea.seoul.jongno", new Zone { Id = IdGenerator.CreateId(), Name = "zone.south_korea.seoul.jongno", Type = ZoneTypeEnum.Downtown, CityId = cities["city.south_korea.seoul"].Id }},
                    { "zone.france.cannes.cannes_centre", new Zone { Id = IdGenerator.CreateId(), Name = "zone.france.cannes.cannes_centre", Type = ZoneTypeEnum.Downtown, CityId = cities["city.france.cannes"].Id }},
                    { "zone.france.paris.paris_1er", new Zone { Id = IdGenerator.CreateId(), Name = "zone.france.paris.paris_1er", Type = ZoneTypeEnum.Downtown, CityId = cities["city.france.paris"].Id }},
                    { "zone.india.mumbai.south_mumbai", new Zone { Id = IdGenerator.CreateId(), Name = "zone.india.mumbai.south_mumbai", Type = ZoneTypeEnum.Downtown, CityId = cities["city.india.mumbai"].Id }},

                     // Residential zones
                    { "zone.brazil.sao_paulo.higienopolis", new Zone { Id = IdGenerator.CreateId(), Name = "zone.brazil.sao_paulo.higienopolis", Type = ZoneTypeEnum.Residential, CityId = cities["city.brazil.sao_paulo"].Id }},
                    { "zone.turkey.istanbul.bebek", new Zone { Id = IdGenerator.CreateId(), Name = "zone.turkey.istanbul.bebek", Type = ZoneTypeEnum.Residential, CityId = cities["city.turkey.istanbul"].Id }},
                    { "zone.mexico.mexico_city.polanco", new Zone { Id = IdGenerator.CreateId(), Name = "zone.mexico.mexico_city.polanco", Type = ZoneTypeEnum.Residential, CityId = cities["city.mexico.mexico_city"].Id }},
                    { "zone.germany.berlin.charlottenburg", new Zone { Id = IdGenerator.CreateId(), Name = "zone.germany.berlin.charlottenburg", Type = ZoneTypeEnum.Residential, CityId = cities["city.germany.berlin"].Id }},
                    { "zone.italy.rome.trastevere", new Zone { Id = IdGenerator.CreateId(), Name = "zone.italy.rome.trastevere", Type = ZoneTypeEnum.Residential, CityId = cities["city.italy.rome"].Id }},
                    { "zone.united_kingdom.london.kensington", new Zone { Id = IdGenerator.CreateId(), Name = "zone.united_kingdom.london.kensington", Type = ZoneTypeEnum.Residential, CityId = cities["city.united_kingdom.london"].Id }},
                    { "zone.canada.quebec.cap_rouge", new Zone { Id = IdGenerator.CreateId(), Name = "zone.canada.quebec.cap_rouge", Type = ZoneTypeEnum.Residential, CityId = cities["city.canada.quebec"].Id }},
                    { "zone.united_states.los_angeles.beverly_hills", new Zone { Id = IdGenerator.CreateId(), Name = "zone.united_states.los_angeles.beverly_hills", Type = ZoneTypeEnum.Residential, CityId = cities["city.united_states.los_angeles"].Id }},
                    { "zone.china.beijing.chaoyang", new Zone { Id = IdGenerator.CreateId(), Name = "zone.china.beijing.chaoyang", Type = ZoneTypeEnum.Residential, CityId = cities["city.china.beijing"].Id }},
                    { "zone.south_korea.seoul.gangnam", new Zone { Id = IdGenerator.CreateId(), Name = "one.south_korea.seoul.gangnam", Type = ZoneTypeEnum.Residential, CityId = cities["city.south_korea.seoul"].Id }},
                    { "zone.france.cannes.la_bocca", new Zone { Id = IdGenerator.CreateId(), Name = "zone.france.cannes.la_bocca", Type = ZoneTypeEnum.Residential, CityId = cities["city.france.cannes"].Id }},
                    { "zone.france.paris.montmartre", new Zone { Id = IdGenerator.CreateId(), Name = "zone.france.paris.montmartre", Type = ZoneTypeEnum.Residential, CityId = cities["city.france.paris"].Id }},
                    { "zone.india.mumbai.bandra", new Zone { Id = IdGenerator.CreateId(), Name = "zone.india.mumbai.bandra", Type = ZoneTypeEnum.Residential, CityId = cities["city.india.mumbai"].Id }},

                    // Commercial zones
                    { "zone.brazil.sao_paulo.paulista", new Zone { Id = IdGenerator.CreateId(), Name = "zone.brazil.sao_paulo.paulista", Type = ZoneTypeEnum.Commercial, CityId = cities["city.brazil.sao_paulo"].Id }},
                    { "zone.turkey.istanbul.nisantasi", new Zone { Id = IdGenerator.CreateId(), Name = "zone.turkey.istanbul.nisantasi", Type = ZoneTypeEnum.Commercial, CityId = cities["city.turkey.istanbul"].Id }},
                    { "zone.mexico.mexico_city.zona_rosa", new Zone { Id = IdGenerator.CreateId(), Name = "zone.mexico.mexico_city.zona_rosa", Type = ZoneTypeEnum.Commercial, CityId = cities["city.mexico.mexico_city"].Id }},
                    { "zone.germany.berlin.potsdamer_platz", new Zone { Id = IdGenerator.CreateId(), Name = "zone.germany.berlin.potsdamer_platz", Type = ZoneTypeEnum.Commercial, CityId = cities["city.germany.berlin"].Id }},
                    { "zone.italy.rome.via_del_corso", new Zone { Id = IdGenerator.CreateId(), Name = "zone.italy.rome.via_del_corso", Type = ZoneTypeEnum.Commercial, CityId = cities["city.italy.rome"].Id }},
                    { "zone.united_kingdom.london.soho", new Zone { Id = IdGenerator.CreateId(), Name = "zone.united_kingdom.london.soho", Type = ZoneTypeEnum.Commercial, CityId = cities["city.united_kingdom.london"].Id }},
                    { "zone.canada.quebec.saint_roch", new Zone { Id = IdGenerator.CreateId(), Name = "zone.canada.quebec.saint_roch", Type = ZoneTypeEnum.Commercial, CityId = cities["city.canada.quebec"].Id }},
                    { "zone.united_states.los_angeles.hollywood", new Zone { Id = IdGenerator.CreateId(), Name = "zone.united_states.los_angeles.hollywood", Type = ZoneTypeEnum.Commercial, CityId = cities["city.united_states.los_angeles"].Id }},
                    { "zone.china.beijing.sanlitun", new Zone { Id = IdGenerator.CreateId(), Name = "zone.china.beijing.sanlitun", Type = ZoneTypeEnum.Commercial, CityId = cities["city.china.beijing"].Id }},
                    { "zone.south_korea.seoul.myeongdong", new Zone { Id = IdGenerator.CreateId(), Name = "zone.south_korea.seoul.myeongdong", Type = ZoneTypeEnum.Commercial, CityId = cities["city.south_korea.seoul"].Id }},
                    { "zone.france.cannes.la_croisette", new Zone { Id = IdGenerator.CreateId(), Name = "zone.france.cannes.la_croisette", Type = ZoneTypeEnum.Commercial, CityId = cities["city.france.cannes"].Id }},
                    { "zone.france.paris.champs_elysees", new Zone { Id = IdGenerator.CreateId(), Name = "zone.france.paris.champs_elysees", Type = ZoneTypeEnum.Commercial, CityId = cities["city.france.paris"].Id }},
                    { "zone.india.mumbai.colaba", new Zone { Id = IdGenerator.CreateId(), Name = "zone.india.mumbai.colaba", Type = ZoneTypeEnum.Commercial, CityId = cities["city.india.mumbai"].Id }},

                    // Industrial zones
                    { "zone.brazil.sao_paulo.cidade_industrial", new Zone { Id = IdGenerator.CreateId(), Name = "zone.brazil.sao_paulo.cidade_industrial", Type = ZoneTypeEnum.Industrial, CityId = cities["city.brazil.sao_paulo"].Id }},
                    { "zone.turkey.istanbul.tuzla", new Zone { Id = IdGenerator.CreateId(), Name = "zone.turkey.istanbul.tuzla", Type = ZoneTypeEnum.Industrial, CityId = cities["city.turkey.istanbul"].Id }},
                    { "zone.mexico.mexico_city.industrial_vallejo", new Zone { Id = IdGenerator.CreateId(), Name = "zone.mexico.mexico_city.industrial_vallejo", Type = ZoneTypeEnum.Industrial, CityId = cities["city.mexico.mexico_city"].Id }},
                    { "zone.germany.berlin.industriepark_berlin", new Zone { Id = IdGenerator.CreateId(), Name = "zone.germany.berlin.industriepark_berlin", Type = ZoneTypeEnum.Industrial, CityId = cities["city.germany.berlin"].Id }},
                    { "zone.italy.rome.ostiense", new Zone { Id = IdGenerator.CreateId(), Name = "zone.italy.rome.ostiense", Type = ZoneTypeEnum.Industrial, CityId = cities["city.italy.rome"].Id }},
                    { "zone.united_kingdom.london.park_royal", new Zone { Id = IdGenerator.CreateId(), Name = "zone.united_kingdom.london.park_royal", Type = ZoneTypeEnum.Industrial, CityId = cities["city.united_kingdom.london"].Id }},
                    { "zone.canada.quebec.par_industriel_quebec", new Zone { Id = IdGenerator.CreateId(), Name = "zone.canada.quebec.par_industriel_quebec", Type = ZoneTypeEnum.Industrial, CityId = cities["city.canada.quebec"].Id }},
                    { "zone.united_states.los_angeles.industrial_district", new Zone { Id = IdGenerator.CreateId(), Name = "zone.united_states.los_angeles.industrial_district", Type = ZoneTypeEnum.Industrial, CityId = cities["city.united_states.los_angeles"].Id }},
                    { "zone.china.beijing.beijing_economic_technological_dev_area", new Zone { Id = IdGenerator.CreateId(), Name = "zone.china.beijing.beijing_economic_technological_dev_area", Type = ZoneTypeEnum.Industrial, CityId = cities["city.china.beijing"].Id }},
                    { "zone.south_korea.seoul.digital_media_city", new Zone { Id = IdGenerator.CreateId(), Name = "zone.south_korea.seoul.digital_media_city", Type = ZoneTypeEnum.Industrial, CityId = cities["city.south_korea.seoul"].Id }},
                    { "zone.france.cannes.cannes_la_bocca", new Zone { Id = IdGenerator.CreateId(), Name = "zone.france.cannes.cannes_la_bocca", Type = ZoneTypeEnum.Industrial, CityId = cities["city.france.cannes"].Id }},
                    { "zone.france.paris.paris_saclay", new Zone { Id = IdGenerator.CreateId(), Name = "zone.france.paris.paris_saclay", Type = ZoneTypeEnum.Industrial, CityId = cities["city.france.paris"].Id }},
                    { "zone.india.mumbai.mahape", new Zone { Id = IdGenerator.CreateId(), Name = "zone.india.mumbai.mahape", Type = ZoneTypeEnum.Industrial, CityId = cities["city.india.mumbai"].Id }},

                    // Countryside zones
                    { "zone.brazil.sao_paulo.embu_das_artes", new Zone { Id = IdGenerator.CreateId(), Name = "zone.brazil.sao_paulo.embu_das_artes", Type = ZoneTypeEnum.CountrySide, CityId = cities["city.brazil.sao_paulo"].Id }},
                    { "zone.turkey.istanbul.polonezkoy", new Zone { Id = IdGenerator.CreateId(), Name = "zone.turkey.istanbul.polonezkoy", Type = ZoneTypeEnum.CountrySide, CityId = cities["city.turkey.istanbul"].Id }},
                    { "zone.mexico.mexico_city.xochimilco", new Zone { Id = IdGenerator.CreateId(), Name = "zone.mexico.mexico_city.xochimilco", Type = ZoneTypeEnum.CountrySide, CityId = cities["city.mexico.mexico_city"].Id }},
                    { "zone.germany.berlin.spreewald", new Zone { Id = IdGenerator.CreateId(), Name = "zone.germany.berlin.spreewald", Type = ZoneTypeEnum.CountrySide, CityId = cities["city.germany.berlin"].Id }},
                    { "zone.italy.rome.castelli_romani", new Zone { Id = IdGenerator.CreateId(), Name = "zone.italy.rome.castelli_romani", Type = ZoneTypeEnum.CountrySide, CityId = cities["city.italy.rome"].Id }},
                    { "zone.united_kingdom.london.kent_countryside", new Zone { Id = IdGenerator.CreateId(), Name = "zone.united_kingdom.london.kent_countryside", Type = ZoneTypeEnum.CountrySide, CityId = cities["city.united_kingdom.london"].Id }},
                    { "zone.canada.quebec.charlevoix", new Zone { Id = IdGenerator.CreateId(), Name = "zone.canada.quebec.charlevoix", Type = ZoneTypeEnum.CountrySide, CityId = cities["city.canada.quebec"].Id }},
                    { "zone.united_states.los_angeles.malibu_wine_safari", new Zone { Id = IdGenerator.CreateId(), Name = "zone.united_states.los_angeles.malibu_wine_safari", Type = ZoneTypeEnum.CountrySide, CityId = cities["city.united_states.los_angeles"].Id }},
                    { "zone.china.beijing.mutianyu_great_wall", new Zone { Id = IdGenerator.CreateId(), Name = "zone.china.beijing.mutianyu_great_wall", Type = ZoneTypeEnum.CountrySide, CityId = cities["city.china.beijing"].Id }},
                    { "zone.south_korea.seoul.bukhansan_national_park", new Zone { Id = IdGenerator.CreateId(), Name = "zone.south_korea.seoul.bukhansan_national_park", Type = ZoneTypeEnum.CountrySide, CityId = cities["city.south_korea.seoul"].Id }},
                    { "zone.france.cannes.ile_saint_marguerite", new Zone { Id = IdGenerator.CreateId(), Name = "zone.france.cannes.ile_saint_marguerite", Type = ZoneTypeEnum.CountrySide, CityId = cities["city.france.cannes"].Id }},
                    { "zone.france.paris.versailles", new Zone { Id = IdGenerator.CreateId(), Name = "zone.france.paris.versailles", Type = ZoneTypeEnum.CountrySide, CityId = cities["city.france.paris"].Id }},
                    { "zone.india.mumbai.elephanta_caves", new Zone { Id = IdGenerator.CreateId(), Name = "zone.india.mumbai.elephanta_caves", Type = ZoneTypeEnum.CountrySide, CityId = cities["city.india.mumbai"].Id }},

                    // Slum zones
                    { "zone.brazil.sao_paulo.heliopolis", new Zone { Id = IdGenerator.CreateId(), Name = "zone.brazil.sao_paulo.heliopolis", Type = ZoneTypeEnum.Slum, CityId = cities["city.brazil.sao_paulo"].Id }},
                    { "zone.turkey.istanbul.tarlabasi", new Zone { Id = IdGenerator.CreateId(), Name = "zone.turkey.istanbul.tarlabasi", Type = ZoneTypeEnum.Slum, CityId = cities["city.turkey.istanbul"].Id }},
                    { "zone.mexico.mexico_city.neza", new Zone { Id = IdGenerator.CreateId(), Name = "zone.mexico.mexico_city.neza", Type = ZoneTypeEnum.Slum, CityId = cities["city.mexico.mexico_city"].Id }},
                    { "zone.germany.berlin.rudow", new Zone { Id = IdGenerator.CreateId(), Name = "zone.germany.berlin.rudow", Type = ZoneTypeEnum.Slum, CityId = cities["city.germany.berlin"].Id }},
                    { "zone.italy.rome.tor_bella_monaca", new Zone { Id = IdGenerator.CreateId(), Name = "zone.italy.rome.tor_bella_monaca", Type = ZoneTypeEnum.Slum, CityId = cities["city.italy.rome"].Id }},
                    { "zone.united_kingdom.london.brixton", new Zone { Id = IdGenerator.CreateId(), Name = "zone.united_kingdom.london.brixton", Type = ZoneTypeEnum.Slum, CityId = cities["city.united_kingdom.london"].Id }},
                    //{ "zone.canada.quebec.saint_roch", new Zone { Id = IdGenerator.CreateId(), Name = "zone.canada.quebec.saint_roch", Type = ZoneTypeEnum.Slum, CityId = cities["city.canada.quebec"].Id }},
                    { "zone.united_states.los_angeles.skid_row", new Zone { Id = IdGenerator.CreateId(), Name = "zone.united_states.los_angeles.skid_row", Type = ZoneTypeEnum.Slum, CityId = cities["city.united_states.los_angeles"].Id }},
                    { "zone.china.beijing.migrant_villages", new Zone { Id = IdGenerator.CreateId(), Name = "zone.china.beijing.migrant_villages", Type = ZoneTypeEnum.Slum, CityId = cities["city.china.beijing"].Id }},
                    { "zone.south_korea.seoul.guryong_village", new Zone { Id = IdGenerator.CreateId(), Name = "zone.south_korea.seoul.guryong_village", Type = ZoneTypeEnum.Slum, CityId = cities["city.south_korea.seoul"].Id }},
                    { "zone.france.cannes.les_moulieres", new Zone { Id = IdGenerator.CreateId(), Name = "zone.france.cannes.les_moulieres", Type = ZoneTypeEnum.Slum, CityId = cities["city.france.cannes"].Id }},
                    { "zone.france.paris.banlieues", new Zone { Id = IdGenerator.CreateId(), Name = "zone.france.paris.banlieues", Type = ZoneTypeEnum.Slum, CityId = cities["city.france.paris"].Id }},
                    { "zone.india.mumbai.dharavi", new Zone { Id = IdGenerator.CreateId(), Name = "zone.india.mumbai.dharavi", Type = ZoneTypeEnum.Slum, CityId = cities["city.india.mumbai"].Id }}


                };

            ModelBuilder.Entity<Zone>().HasData(zones.Values.ToList());

            var locations = new Dictionary<string, Location> {
                { "Prefeitura de São Paulo", new Location { Id = IdGenerator.CreateId(), Name = "Prefeitura de São Paulo", ZoneId = zones["zone.brazil.sao_paulo.praca_da_se"].Id, LocationType = LocationTypeEnum.CityHall, Scoring = ScoringEnum.Good } }
            };

            ModelBuilder.Entity<Location>().HasData(locations.Values.ToList());
        }
    }
}
