using System;

namespace Task2
{
    class Program
    {

        //Make a method RaceCars() that will get two Car objects that will determine which
        //car will win and print the result in the console.
        //Make 4 car objects and 4 driver objects.


        static void RaceCar(Car car1, Driver driver1, Car car2, Driver driver2)
        {

            Console.WriteLine("The winner is: ");
            if (car1.CalculateSpeed(driver1) > car2.CalculateSpeed(driver2))
            {
                Console.WriteLine("Car no.1:" + car1.Model);
                Console.WriteLine("with speed " + car1.CalculateSpeed(driver1) + " droven by " + driver1.Name);


            }
            else
            {
                Console.WriteLine("Car no.2: " + car2.Model);
                Console.WriteLine("with speed " + +car2.CalculateSpeed(driver2) + " droven by " + driver2.Name);

            }
        }
        static void Main(string[] args)
        {
            //Ask the user to select a two cars and two drivers for the cars.
            //Add the drivers to the cars and call the RaceCars() methods

            //BONUS 1: If a user chooses option one for the first care, eliminate
            //that option when the user picks car two.---almost done----

            //BONUS 2: Make the Output message say what was the model of the car
            //that won, what speed was it going and which driver was driving it. ------done-----

            //BONUS 3: Implement a Race Again Feature where you ask the user if he wants to race again and
            //repeat the racing function.----------done-----------

            Car hyundai = new Car();
            hyundai.Model = "Hyundai Tucson";
            hyundai.Speed = 196;



            Car mazda = new Car();
            mazda.Model = "Mazda CX-30";
            mazda.Speed = 186;


            Car ferrari = new Car();
            ferrari.Model = "Ferrari SF90 Stradale";
            ferrari.Speed = 340;


            Car porsche = new Car();
            porsche.Model = "Porsche 918 Spyder";
            porsche.Speed = 214;

            //driver skills from 5 to 10
            Driver driver111 = new Driver();
            driver111.Name = "Carmen";
            driver111.Skill = 9;

            Driver driver222 = new Driver();
            driver222.Name = "Justin";
            driver222.Skill = 8;

            Driver driver333 = new Driver();
            driver333.Name = "Nico";
            driver333.Skill = 7;

            Driver driver444 = new Driver();
            driver444.Name = "Lime";
            driver444.Skill = 8;



            for (; ; )
            {
                Console.WriteLine("Choose the first car:  1-Ferrari SF90 Stradale; 2-Hyundai Tucson; 3-Mazda CX-30; 4-Porsche 918 Spyder;");
                int chooseCar1 = int.Parse(Console.ReadLine());
                Car carOne = hyundai;


                switch (chooseCar1)
                {
                    case 1:
                        carOne = ferrari;

                        Console.WriteLine($"You chose:{ferrari.Model}");
                        break;
                    case 2:
                        carOne = hyundai;
                        Console.WriteLine($"You chose:{hyundai.Model}");
                        break;
                    case 3:
                        carOne = mazda;
                        Console.WriteLine($"You chose:{mazda.Model}");
                        break;
                    case 4:
                        carOne = porsche;
                        Console.WriteLine($"You chose:{porsche.Model}");

                        break;
                    default:
                        Console.WriteLine("No such car");
                        while (chooseCar1 > 4 || chooseCar1 <= 0)
                        {
                            Console.WriteLine("Choose the first car:  1-Ferrari SF90 Stradale; 2-Hyundai Tucson; 3-Mazda CX-30; 4-Porsche 918 Spyder;");
                            chooseCar1 = int.Parse(Console.ReadLine());
                        }
                        break;
                }




                Console.WriteLine("Choose a driver: 1-Lime; 2-Nico; 3-Justin; 4-Carmen;");
                int chooseDriver = int.Parse(Console.ReadLine());
                Driver driverOne = driver111;

                switch (chooseDriver)
                {
                    case 1:
                        driverOne = driver444;

                        Console.WriteLine($"You chose:{driver444.Name}");
                        break;
                    case 2:
                        driverOne = driver333;
                        Console.WriteLine($"You chose:{ driver333.Name}");
                        break;
                    case 3:
                        driverOne = driver222;
                        Console.WriteLine($"You chose:{driver222.Name}");
                        break;
                    case 4:
                        driverOne = driver111;

                        Console.WriteLine($"You chose:{driver111.Name}");

                        break;
                    default:
                        Console.WriteLine("No such driver");
                        while (chooseDriver > 4 || chooseDriver <= 0)
                        {
                            Console.WriteLine("Choose a driver: 1-Lime; 2-Nico; 3-Justin; 4-Carmen;");
                            chooseDriver = int.Parse(Console.ReadLine());
                        }
                        break;
                }


                Console.WriteLine("Choose the second car: 1-Ferrari SF90 Stradale; 2-Hyundai Tucson; 3-Mazda CX-30; 4-Porsche 918 Spyder;");
                int chooseCar2 = int.Parse(Console.ReadLine());
                Car carTwo = hyundai;

                switch (chooseCar2)
                {
                    case 1:

                        while (chooseCar2 == chooseCar1)
                        {
                            Console.WriteLine("Can't pick the same car! Try Again");
                            chooseCar2 = int.Parse(Console.ReadLine());
                        }

                        carTwo = ferrari;
                        Console.WriteLine($"You chose:{ferrari.Model}");
                        break;
                    case 2:

                        while (chooseCar2 == chooseCar1)
                        {
                            Console.WriteLine("Can't pick the same car! Try Again");
                            chooseCar2 = int.Parse(Console.ReadLine());
                        }

                        carTwo = hyundai;
                        Console.WriteLine($"You chose:{hyundai.Model}");
                        break;
                    case 3:
                        while (chooseCar2 == chooseCar1)
                        {
                            Console.WriteLine("Can't pick the same car! Try Again");
                            chooseCar2 = int.Parse(Console.ReadLine());
                        }

                        carTwo = mazda;
                        Console.WriteLine($"You chose:{mazda.Model}");
                        break;
                    case 4:
                        while (chooseCar2 == chooseCar1)
                        {
                            Console.WriteLine("Can't pick the same car! Try Again");
                            chooseCar2 = int.Parse(Console.ReadLine());
                        }

                        carTwo = porsche;
                        Console.WriteLine($"You chose:{porsche.Model}");

                        break;
                    default:
                        Console.WriteLine("No such car!");
                        if (chooseCar2 > 4 || chooseCar2 <= 0 || chooseCar1 == chooseCar2)
                        {
                            for (; ; )
                            {
                                Console.WriteLine("Choose the second: 1-Ferrari SF90 Stradale; 2-Hyundai Tucson; 3-Mazda CX-30; 4-Porsche 918 Spyder;");
                                chooseCar2 = int.Parse(Console.ReadLine());

                            }
                        }
                        //zoshto ne mi raboti ovoj loop/case defaulth
                        //koga vnesuvam ista kola kako i prvata kola
                        //mi printa cant pick the same car
                        //naredno ako vnesam -1
                        //mi printa deka sum ja izbrala ferari kolata
                        //neli treba da vleze vo default zatoa shto e negativen broj i plus zatoa shto ne postoi takov case -1;
                        //defaulth case ne mi raboti kako shto treba samo kaj switch-ot za vtorata kola i switch-ot za vtoriot vozac, se drugo si raboti

                        break;

                }

                Console.WriteLine("Choose the second driver: 1-Lime; 2-Nico; 3-Justin; 4-Carmen;");
                int chooseDriver2 = int.Parse(Console.ReadLine());
                Driver driverTwo = driver111;

                switch (chooseDriver2)
                {
                    case 1:
                        while (chooseDriver2 == chooseDriver)
                        {
                            Console.WriteLine("Can't pick the same driver! Try Again");
                            chooseDriver2 = int.Parse(Console.ReadLine());
                        }
                        driverTwo = driver444;
                        Console.WriteLine($"You chose:{driver444.Name}");
                        break;
                    case 2:
                        while (chooseDriver2 == chooseDriver)
                        {
                            Console.WriteLine("Can't pick the same driver! Try Again");
                            chooseDriver2 = int.Parse(Console.ReadLine());
                        }
                        driverTwo = driver333;
                        Console.WriteLine($"You chose:{ driver333.Name}");
                        break;
                    case 3:
                        while (chooseDriver2 == chooseDriver)
                        {
                            Console.WriteLine("Can't pick the same driver! Try Again");
                            chooseDriver2 = int.Parse(Console.ReadLine());
                        }
                        driverTwo = driver222;
                        Console.WriteLine($"You chose:{driver222.Name}");
                        break;
                    case 4:
                        while (chooseDriver2 == chooseDriver)
                        {
                            Console.WriteLine("Can't pick the same driver! Try Again");
                            chooseDriver2 = int.Parse(Console.ReadLine());
                        }
                        driverTwo = driver111;

                        Console.WriteLine($"You chose:{driver111.Name}");

                        break;
                    default:
                        if (chooseDriver2 > 4 || chooseDriver2 <= 0 || chooseDriver2 == chooseDriver)
                            for (; ; )
                            {
                                Console.WriteLine("Choose the second driver: 1-Lime; 2-Nico; 3-Justin; 4-Carmen;");
                                chooseCar2 = int.Parse(Console.ReadLine());

                            }
                        break;

                }

                //go imam istiot problem kako i vo prethodnata domashna
                //ne mi dozvoluva da gi deklariram objektite prazni
                //morashe da im opredelam inicijalna vrednost

                RaceCar(carOne, driverOne, carTwo, driverTwo);

                Console.WriteLine("Would you like to race again?(answer with yes or no)");
                string RaceAgain = Console.ReadLine().ToLower();
                if (RaceAgain == "yes")
                    continue;

                else break;
            }



        }
    }
}
