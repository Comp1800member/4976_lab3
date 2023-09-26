using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Models
{
    public static class SeedData {
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetTeams()
        );
        modelBuilder.Entity<City>().HasData(
            GetPlayers()
        );
    }
    public static List<Province> GetTeams() {
        List<Province> teams = new List<Province>() {
            new Province() {    // 1
                ProvinceCode="BC",
                ProvinceName="British Columbia",
            },
            new Province() {    //2
                ProvinceCode="AB",
                ProvinceName="Alberta",
            },
            new Province() {    // 3
                ProvinceCode="ON",
                ProvinceName="Ontario",
            }
        };

        return teams;
    }

    public static List<City> GetPlayers() {
        List<City> players = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Vancouver",
                Population = 675218,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 2,
                CityName = "Prince George",
                Population = 123634,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 3,
                CityName = "Victora",
                Population = 1624342,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 4,
                CityName = "Calgary",
                Population = 754462,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 5,
                CityName = "Edmonton",
                Population = 5143535,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 6,
                CityName = "Medhat",
                Population = 1345522,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 7,
                CityName = "Thunder Bay",
                Population = 1345513,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 8,
                CityName = "Toronto",
                Population = 6134345,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 9,
                CityName = "Guelph",
                Population = 453226,
                ProvinceCode = "ON"
            },
        };

        return players;
    }
}
}