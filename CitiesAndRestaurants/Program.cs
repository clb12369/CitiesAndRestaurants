using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesAndRestaurants
{
    // Create 3 Cities, each with at least 5 Neighborhoods and 10 Restaurants
    // City should have a method to query all that Restaurants near a LatLng
    // City should have a method to query for all of the Restaurants of a certain Category
    // Neighborhood should have a method to query for all Restaurants of a certain Category
    class Program
    {
        static void Main(string[] args)
        {
            // Create 3 Cities
            City cypress = new City("Cypress", "TX");
            cypress.coords = new LatLng("29.5941, 95.4003");
            City houston = new City("Houston", "TX");
            houston.coords = new LatLng("29.4546, 95.2259");
            City austin = new City("Austin", "TX");
            austin.coords = new LatLng("30.1500, 97.4500");
            Console.WriteLine(austin.coords);

            // Create Neighboring Cities
            cypress.neighboringCities = new List<City>();
            cypress.neighboringCities.Add(houston);
            cypress.neighboringCities.Add(austin);

            houston.neighboringCities = new List<City>();
            houston.neighboringCities.Add(cypress);
            houston.neighboringCities.Add(austin);

            austin.neighboringCities = new List<City>();
            austin.neighboringCities.Add(cypress);
            austin.neighboringCities.Add(houston);



            // Create 5 Neighborhoods for Cypress
            Neighborhood windhaven = new Neighborhood("Wndhaven", cypress);
            cypress.burroughs.Add(windhaven);
            Neighborhood cypressCreek = new Neighborhood("Cypress Creek", cypress);
            cypress.burroughs.Add(cypressCreek);
            Neighborhood towneLake = new Neighborhood("Towne Lake", cypress);
            cypress.burroughs.Add(towneLake);
            Neighborhood loneOak = new Neighborhood("Lone Oak", cypress);
            cypress.burroughs.Add(loneOak);
            Neighborhood blackhorseRanch = new Neighborhood("Black Horse Ranch", cypress);
            cypress.burroughs.Add(blackhorseRanch);

            // Create 2 Restaurants for each Neighborhood in Cypress
            //Windhaven
            Restaurant tomiko = new Restaurant("Tomiko Sushi");
            windhaven.restaurants.Add(tomiko);
            tomiko.category = Category.Japanese; // Should be Japanese
            tomiko.websiteUrl = "http://www.tomikosushi.com";
            tomiko.address = new Address();
            tomiko.address.streetAddress = "29110 Highway 290";
            tomiko.address.city = cypress;
            tomiko.address.state = "TX";
            tomiko.address.zip = 77433;
            tomiko.address.latlng = new LatLng("29.994824, 95.753911");

            Restaurant gringos = new Restaurant("Gringo's Mexican Kitchen");
            windhaven.restaurants.Add(gringos);
            gringos.category = Category.Mexican; // should be Mexican
            gringos.websiteUrl = "https://www.gringostexmex.com";
            gringos.address = new Address();
            gringos.address.streetAddress = "27030 Northwest Freeway";
            gringos.address.city = cypress;
            gringos.address.state = "TX";
            gringos.address.zip = 77433;
            gringos.address.latlng = new LatLng("29.979231, 95.714817");

            ////Cypress Creek
            Restaurant locatellis = new Restaurant("Locatelli's Pizza");
            cypressCreek.restaurants.Add(locatellis);
            locatellis.category = Category.Italian; // should be Italian
            locatellis.websiteUrl = "https://www.locatellis.com";
            locatellis.address = new Address();
            locatellis.address.streetAddress = "12904 Fry Rd.";
            Console.WriteLine(locatellis.address.streetAddress);
            locatellis.address.city = cypress;
            locatellis.address.state = "TX";
            locatellis.address.zip = 77429;
            locatellis.address.latlng = new LatLng("29.967130, 95.701879");

            Restaurant seasonsCafe = new Restaurant("Season's Harvest Cafe");
            cypressCreek.restaurants.Add(seasonsCafe);
            seasonsCafe.category = Category.American; // should be American
            seasonsCafe.websiteUrl = "https://www.facebook.com/pages/Seasons-Harvest-Cafe/371063685372";
            seasonsCafe.address = new Address();
            seasonsCafe.address.streetAddress = "17303 Shaw Rd.";
            seasonsCafe.address.city = cypress;
            seasonsCafe.address.state = "TX";
            seasonsCafe.address.zip = 77429;
            seasonsCafe.address.latlng = new LatLng("30.022741, 95.643246"); 

            //// Towne Lake
            Restaurant anothai = new Restaurant("Anothai Cuisine");
            towneLake.restaurants.Add(anothai);
            anothai.category = Category.Thai; // should be Thai
            anothai.websiteUrl = "https://www.anothaicuisine.com";// URL does not seem to work
            anothai.address = new Address();
            anothai.address.streetAddress = "25282 Northwest Freeway, Suite 150";
            anothai.address.city = cypress;
            anothai.address.state = "TX";
            anothai.address.zip = 77429;
            anothai.address.latlng = new LatLng("29.964426, 95.686488");

            Restaurant colesCrossing = new Restaurant("Cole's Crossing Breakfast House");
            towneLake.restaurants.Add(colesCrossing);
            colesCrossing.category = Category.American; // should be American
            colesCrossing.websiteUrl = "https://www.facebook.com/pages/Seasons-Harvest-Cafe/371063685372";
            colesCrossing.address = new Address();
            colesCrossing.address.streetAddress = "24140 Highway 290";
            colesCrossing.address.city = cypress;
            colesCrossing.address.state = "TX";
            colesCrossing.address.zip = 77429;
            colesCrossing.address.latlng = new LatLng("29.954342, 95.671464");

            //// Lone Oak
            Restaurant jaxtons = new Restaurant("Jaxton's Bistro");
            loneOak.restaurants.Add(jaxtons);
            jaxtons.category = Category.French; // should be French
            jaxtons.websiteUrl = "https://www.zomato.com/houston/jaxtons-bistro-cypress";
            jaxtons.address = new Address();
            jaxtons.address.streetAddress = "9955 Barker Cypress Rd, Suite 104";
            jaxtons.address.city = cypress;
            jaxtons.address.state = "TX";
            jaxtons.address.zip = 77433;
            jaxtons.address.latlng = new LatLng("29.922355, 95.688225");

            Restaurant burgerTex = new Restaurant("Burger Tex");
            loneOak.restaurants.Add(burgerTex);
            burgerTex.category = Category.American; // should be American
            burgerTex.websiteUrl = "http://www.burgertexgrillcypress.com";
            burgerTex.address = new Address();
            burgerTex.address.streetAddress = "10750 Barker Cypress Rd";
            burgerTex.address.city = cypress;
            burgerTex.address.state = "TX";
            burgerTex.address.zip = 77433;
            burgerTex.address.latlng = new LatLng("29.936718, 95.680469");

            //// Black Horse Ranch
            Restaurant darios = new Restaurant("Dario's American Bistro");
            blackhorseRanch.restaurants.Add(darios);
            darios.category = Category.American; // should be American
            darios.websiteUrl = "http://dariosamericancuisine.com/";
            darios.address = new Address();
            darios.address.streetAddress = "14315 Cypress Rosehill Rd";
            darios.address.city = cypress;
            darios.address.state = "TX";
            darios.address.zip = 77429;
            darios.address.latlng = new LatLng("29.975365, 95.701205");

            Restaurant taquitoJoes = new Restaurant("Taquito Joes");
            blackhorseRanch.restaurants.Add(burgerTex);
            taquitoJoes.category = Category.Mexican; // should be Mexican
            taquitoJoes.websiteUrl = "http://www.taquitojoes.com/";
            taquitoJoes.address = new Address();
            taquitoJoes.address.streetAddress = "12904 Fry Rd, Suite 400";
            taquitoJoes.address.city = cypress;
            taquitoJoes.address.state = "TX";
            taquitoJoes.address.zip = 77433;
            taquitoJoes.address.latlng = new LatLng("29.967232, 95.702109");


            Console.WriteLine("Neighborhoods in Cypress:");
            foreach (Neighborhood neighborhood in cypress.burroughs)
            {
                Console.WriteLine(neighborhood.name);
            }

            // Create 5 Neighborhoods for Houston
            Neighborhood eastEnd = new Neighborhood("East End", houston);
            houston.burroughs.Add(eastEnd);
            Neighborhood memorialCity = new Neighborhood("Memorial City", houston);
            houston.burroughs.Add(memorialCity);
            Neighborhood midtown = new Neighborhood("Midtown", houston);
            houston.burroughs.Add(midtown);
            Neighborhood springBranch = new Neighborhood("Spring Branch", houston);
            houston.burroughs.Add(loneOak);
            Neighborhood westchase = new Neighborhood("Westchase", houston);
            houston.burroughs.Add(westchase);

            // Create 2 Restaurants for each Neighborhood in Houston
            //East End
            Restaurant bradys = new Restaurant("Brady's Landing");
            eastEnd.restaurants.Add(bradys);
            bradys.category = Category.American; // Should be American
            bradys.websiteUrl = "http://www.opentable.com/bradys-landing";
            bradys.address = new Address();
            bradys.address.streetAddress = "8505 Cypress Street";
            bradys.address.city = houston;
            bradys.address.state = "TX";
            bradys.address.zip = 77012;
            bradys.address.latlng = new LatLng("29.725459, 95.275304");

            Restaurant ninfas = new Restaurant("The Original Ninfa's on Navigation");
            eastEnd.restaurants.Add(ninfas);
            ninfas.category = Category.Mexican; // should be Mexican
            ninfas.websiteUrl = "https://www.gringostexmex.com";
            ninfas.address = new Address();
            ninfas.address.streetAddress = "2704 Navigation Blvd";
            ninfas.address.city = houston;
            ninfas.address.state = "TX";
            ninfas.address.zip = 77003;
            ninfas.address.latlng = new LatLng("29.756918, 95.342542");

            //Memorial City
            Restaurant maggianos = new Restaurant("Maggiano's Little Italy");
            memorialCity.restaurants.Add(maggianos);
            maggianos.category = Category.Italian; // should be Italian
            maggianos.websiteUrl = "http://www.maggianos.com/";
            maggianos.address = new Address();
            maggianos.address.streetAddress = "602 Memorial City Mall";
            maggianos.address.city = houston;
            maggianos.address.state = "TX";
            maggianos.address.zip = 77024;
            maggianos.address.latlng = new LatLng("29.781526, 95.542866");

            Restaurant kuu = new Restaurant("Kuu Rerstaurant");
            memorialCity.restaurants.Add(kuu);
            kuu.category = Category.Japanese; // should be Japanese
            kuu.websiteUrl = "https://www.facebook.com/pages/Seasons-Harvest-Cafe/371063685372";
            kuu.address = new Address();
            kuu.address.streetAddress = "947 N Gessner Road, Suite A180";
            kuu.address.city = houston;
            kuu.address.state = "TX";
            kuu.address.zip = 77024;
            kuu.address.latlng = new LatLng("29.783398, 95.545415");

            // Midtown
            Restaurant labaq = new Restaurant("La Baquette French Bakery");
            midtown.restaurants.Add(labaq);
            labaq.category = Category.French; // should be French
            labaq.websiteUrl = "https://www.tripadvisor.com/Restaurant_Review-g56003-d442813-Reviews-La_Baquette_French_Bakery-Houston_Texas.html";
            labaq.address = new Address();
            labaq.address.streetAddress = "2808 Milam St, Suite C";
            labaq.address.city = houston;
            labaq.address.state = "TX";
            labaq.address.zip = 77006;
            labaq.address.latlng = new LatLng("29.745220, 95.377599");

            Restaurant ponzos = new Restaurant("Ponzo's Pizza and Italian Food");
            midtown.restaurants.Add(ponzos);
            ponzos.category = Category.Italian; // should be Italian
            ponzos.websiteUrl = "https://www.tripadvisor.com/Restaurant_Review-g56003-d445943-Reviews-Ponzo_s_Pizza_Italian_Food-Houston_Texas.html";
            ponzos.address = new Address();
            ponzos.address.streetAddress = "2515 Bagby St";
            ponzos.address.city = houston;
            ponzos.address.state = "TX";
            ponzos.address.zip = 77006;
            ponzos.address.latlng = new LatLng("29.748862, 95.3785886");

            // Spring Branch
            Restaurant vieng = new Restaurant("Vieng Thai");
            springBranch.restaurants.Add(vieng);
            vieng.category = Category.Thai; // should be Thai
            vieng.websiteUrl = "https://www.zomato.com/houston/vieng-thai-spring-branch";
            vieng.address = new Address();
            vieng.address.streetAddress = "6929 Long Point Rd";
            vieng.address.city = houston;
            vieng.address.state = "TX";
            vieng.address.zip = 77055;
            vieng.address.latlng = new LatLng("29.802882, 95.470983");

            Restaurant koreaGarden = new Restaurant("Korea Garden");
            springBranch.restaurants.Add(koreaGarden);
            koreaGarden.category = Category.Korean; // should be American
            koreaGarden.websiteUrl = "http://www.burgertexgrillcypress.com";
            koreaGarden.address = new Address();
            koreaGarden.address.streetAddress = "9501 Long Point Rd, Suite Z";
            koreaGarden.address.city = houston;
            koreaGarden.address.state = "TX";
            koreaGarden.address.zip = 77055;
            koreaGarden.address.latlng = new LatLng("29.796988, 95.526257");

            // Westchase
            Restaurant littleThai = new Restaurant("Little Thai Cafe");
            westchase.restaurants.Add(littleThai);
            littleThai.category = Category.Thai; // should be Thai
            littleThai.websiteUrl = "http://www.lt-cafe.com/";
            littleThai.address = new Address();
            littleThai.address.streetAddress = "12002 Richmond Ave, Suite 1200";
            littleThai.address = new Address();
            littleThai.address.city = houston;
            littleThai.address.state = "TX";
            littleThai.address.zip = 77082;
            littleThai.address.latlng = new LatLng("29.731985, 95.590128");

            Restaurant koto = new Restaurant("Koto Japanese Restaurant and Bar");
            westchase.restaurants.Add(koto);
            koto.category = Category.Japanese; // should be Japanese
            koto.websiteUrl = "http://www.kotoonline.com/";
            koto.address = new Address();
            koto.address.streetAddress = "10842 Westheimer Rd";
            koto.address.city = houston;
            koto.address.state = "TX";
            koto.address.zip = 77042;
            koto.address.latlng = new LatLng("29.737909, 95.567609");

            Console.WriteLine("--------------------");
            Console.WriteLine("Neighborhoods in Houston:");
            foreach (Neighborhood neighborhood in houston.burroughs)
            {
                Console.WriteLine(neighborhood.name);
            }

            // Create 5 Heighborhoods for Austin
            Neighborhood brykerWoods = new Neighborhood("Bryker Woods", austin);
            austin.burroughs.Add(brykerWoods);
            Neighborhood hancock = new Neighborhood("Hancock", austin);
            austin.burroughs.Add(hancock);
            Neighborhood hydePark = new Neighborhood("Hyde Park", austin);
            austin.burroughs.Add(hydePark);
            Neighborhood rosedale = new Neighborhood("Rosedale", austin);
            austin.burroughs.Add(rosedale);
            Neighborhood shoalCrest = new Neighborhood("Shoal Crest", austin);
            austin.burroughs.Add(shoalCrest);

            // Create 2 Restaurants for each Neighborhood in Austin
            //Bryker Woods
            Restaurant snowPea = new Restaurant("Snow Pea Chinese Restaurant");
            brykerWoods.restaurants.Add(snowPea);
            snowPea.category = Category.Chinese; // Should be Chinese
            snowPea.websiteUrl = "http://www.snowpeaaustin.com/";
            snowPea.address = new Address();
            snowPea.address.streetAddress = "3706 Jefferson St";
            snowPea.address.city = austin;
            snowPea.address.state = "TX";
            snowPea.address.zip = 78731;
            snowPea.address.latlng = new LatLng("30.309964, 97.751543");

            Restaurant lamadeleine = new Restaurant("laMadeleine Country French Cafe");
            brykerWoods.restaurants.Add(lamadeleine);
            lamadeleine.category = Category.French; // should be French
            lamadeleine.websiteUrl = "http://lamadeleine.com/";
            lamadeleine.address = new Address();
            lamadeleine.address.streetAddress = "3418 N Lamar Blvd";
            lamadeleine.address.city = austin;
            lamadeleine.address.state = "TX";
            lamadeleine.address.zip = 78705;
            lamadeleine.address.latlng = new LatLng("30.303287, 97.744468");

            //Hancock
            Restaurant dolce = new Restaurant("Dolce Vita");
            hancock.restaurants.Add(dolce);
            dolce.category = Category.Italian; // should be Italian
            dolce.websiteUrl = "http://dolcevitaaustin.com/";// URL does not work
            dolce.address = new Address();
            dolce.address.streetAddress = "4222 Duval St";
            dolce.address.city = austin;
            dolce.address.state = "TX";
            dolce.address.zip = 78751;
            dolce.address.latlng = new LatLng("30.304644, 97.726576");

            Restaurant asti = new Restaurant("Asti Trattoria");
            hancock.restaurants.Add(asti);
            asti.category = Category.Italian; // should be Italian
            asti.websiteUrl = "http://astiaustin.com/";
            asti.address = new Address();
            asti.address.streetAddress = "408 E 43rd St";
            asti.address.city = austin;
            asti.address.state = "TX";
            asti.address.zip = 78751;
            asti.address.latlng = new LatLng("30.305112, 97.726178");

            // Hyde Park
            Restaurant hydeParkGrill = new Restaurant("Hyde Park Bar & Grill");
            hydePark.restaurants.Add(hydeParkGrill);
            hydeParkGrill.category = Category.American; // should be American
            hydeParkGrill.websiteUrl = "http://hpbng.com/";
            hydeParkGrill.address = new Address();
            hydeParkGrill.address.streetAddress = "4206 Duval St";
            hydeParkGrill.address.city = austin;
            hydeParkGrill.address.state = "TX";
            hydeParkGrill.address.zip = 78751;
            hydeParkGrill.address.latlng = new LatLng("30.304481, 97.726706");

            Restaurant titaya = new Restaurant("Titaya's Thai Cuisine");
            hydePark.restaurants.Add(titaya);
            titaya.category = Category.Thai; // should be Thai
            titaya.websiteUrl = "http://www.titayasthaicuisine.com/";
            titaya.address = new Address();
            titaya.address.streetAddress = "5501 N Lamar Blvd, Suite C101";
            titaya.address.city = austin;
            titaya.address.state = "TX";
            titaya.address.zip = 78751;
            titaya.address.latlng = new LatLng("30.323794, 97.727400");

            // Rosedale
            Restaurant lamancha = new Restaurant("La Mancha");
            rosedale.restaurants.Add(lamancha);
            lamancha.category = Category.Mexican; // should be Mexican
            lamancha.websiteUrl = "https://lamanchatexmex.com/";
            lamancha.address = new Address();
            lamancha.address.streetAddress = "2203 Hancock Dr";
            lamancha.address.city = austin;
            lamancha.address.state = "TX";
            lamancha.address.zip = 78756;
            lamancha.address.latlng = new LatLng("30.322759, 97.740883");

            Restaurant chilantro = new Restaurant("Chi'lantro");
            rosedale.restaurants.Add(chilantro);
            chilantro.category = Category.Korean; // should be Korean
            chilantro.websiteUrl = "http://www.burgertexgrillcypress.com";
            chilantro.address = new Address();
            chilantro.address.streetAddress = "5222 Burnet Rd";
            chilantro.address.city = austin;
            chilantro.address.state = "TX";
            chilantro.address.zip = 78756;
            chilantro.address.latlng = new LatLng("30.324867, 97.740209");

            // Shoal Crest
            Restaurant musashino = new Restaurant("Musashino Sushi Dokoro");
            shoalCrest.restaurants.Add(musashino);
            musashino.category = Category.Japanese; // should be Japanese
            musashino.websiteUrl = "http://www.musashinosushi.com/";
            musashino.address = new Address();
            musashino.address.streetAddress = "2905 San Gabriel St, Suite 200";
            musashino.address.city = austin;
            musashino.address.state = "TX";
            musashino.address.zip = 78705;
            musashino.address.latlng = new LatLng("30.298353, 97.747614");

            Restaurant rubys = new Restaurant("Ruby's BBQ");
            shoalCrest.restaurants.Add(rubys);
            rubys.category = Category.American; // should be American
            rubys.websiteUrl = "http://rubysbbq.com/";
            rubys.address = new Address();
            rubys.address.streetAddress = "512 W 29th St";
            rubys.address.city = austin;
            rubys.address.state = "TX";
            rubys.address.zip = 78705;
            rubys.address.latlng = new LatLng("30.295734, 97.742342");

            Console.WriteLine("--------------------");
            Console.WriteLine("Neighborhoods in Austin:");
            foreach (Neighborhood neighborhood in houston.burroughs)
            {
                Console.WriteLine(neighborhood.name);
            }

            Console.ReadLine();


        }
    }

    public enum Category
    {
        Italian,
        American,
        Thai,
        German,
        French,
        English,
        Mexican,
        Spanish,
        Chinese,
        Korean,
        Japanese,
        Other
    }

    public class City
    {
        public string name;
        public string state;
        public LatLng coords;
        public List<Neighborhood> burroughs = new List<Neighborhood>();
        public List<Restaurant> restaurants = new List<Restaurant>();
        public List<City> neighboringCities = new List<City>();

        public City(string name, string state)
        {
            this.name = name;
            this.state = state;
        }


        public City(LatLng coords)
        {
            this.coords = coords;
        }

        //public static Restaurant findRestaurantsNearLatLng()
        //{

        //}

        //public static Restaurant findRestaurantsByCategory()
        //{

        //}


    }

    public class Neighborhood
    {
        public string name;
        public City city;
        public List<Restaurant> restaurants = new List<Restaurant>();

        public Neighborhood(string name, City city)
        {
            this.name = name;
            this.city = city;
        }

        //public static Restaurant findRestaurantsByCategory()
        //{

        //}
    }

    public class Restaurant
    {
        public string name;
        public Address address;
        public Category category;
        public string websiteUrl;

        public Restaurant(string name)
        {
            this.name = name;
        }

        public Restaurant(Address address)
        {
            this.address = address;
        }

        public Restaurant(Category category)
        {
            this.category = category;
        }

        //public Restaurant(string websiteUrl)
        //{
        //    this.websiteUrl = websiteUrl;
        //}



    }

    public class LatLng
    {
        public double Lat;
        public double Lng;
        double[] latlng = new double[2];


        public LatLng(string coord)
        {

            var coords = coord.Split(',').Select(s => double.Parse(s)).ToArray();

            Lat = coords[0];
            Lng = coords[1];

        }


        public override string ToString()
        {
            return Lat.ToString() + "," + Lng.ToString();
        }

    }

    public class Address
    {
        public string streetAddress;
        public int zip;
        public City city;
        public string state;
        public LatLng latlng;

        public Address()
        {

        }
        public Address(string streetAddress, int zip, City city, string state, LatLng latlng)
        {
            this.streetAddress = streetAddress;
            this.zip = zip;
            this.city = city;
            this.state = state;
            this.latlng = latlng;
        }

        public Address(string streetAddress)
        {
            this.streetAddress = streetAddress;
        }
    }


}
