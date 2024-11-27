namespace O_348A_Vehicles;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("NF123456", "147kw", 200, "green", "lightweight");
        Car car2 = new Car("NF654321", "150kw", 195, "blue", "lightweight");
        Boat boat1 = new Boat("ABC123", "100kw", 30, 500);
        Airplane airplane1 = new Airplane("LN1234", "150kw", 30, 10, "10T Jet plane");
        
        car1.ShowInfo();
        car2.ShowInfo();
        car1.CompareWith(car1, car2);
        car1.CompareWith(car1, car1);
        car1.Transport();
        airplane1.Transport();
        airplane1.ShowInfo();
        boat1.ShowInfo();


        //     Printe informasjon om en en bil 1 med reg. nr NF123456, 147kw effekt, maksfart 200km/t, grønn farge av typen lett kjøretøy.
        //     Printe informasjon om en annen bil (bil 2) med reg. nr NF654321, 150kw effekt, maksfart 195km/t, blå farge og av typen lett kjøretøy
        //     Sammenlikne de to bilene over for å sjekke om de er det samme kjøretøyet
        //     Printe informasjon om et fly med kjennetegn LN1234, 1000kw effekt, 30m vingespenn, 2tonn lasteevne, 10 tonn egenvekt I flyklasse jetfly
        //     Konsollprogrammet skal be flyet om å fly og printe dette i konsollet.
        //     Konsollprogrammet skal be bil 1 om å kjøre og printe dette I konsollet
        //     Printe informasjon om en båt med kjennetegn ABC123, 100kw effekt, maksfart på 30knop, 500kg bruttotonnasje.
        //
    }
}