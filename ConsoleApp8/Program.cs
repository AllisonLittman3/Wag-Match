using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wagMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //add shelter

            List<Shelter> shelterList = new List<Shelter>();
            Shelter newShelter = new Shelter();
            //add shelter to list
            shelterList.Add(newShelter);

            Console.ReadLine();
            //create list of dogs
            List<Dog> dogList = new List<Dog>();

            string newDogAnswer = "YES";

            //add new dogs to list until don't want to add any more
            while (newDogAnswer == "YES")
            {
                Console.WriteLine("Please register your dog with Wag Match.");
                Dog newDog = new Dog();
                Console.Write("Please enter the dog's name: ");
                newDog.Name = Console.ReadLine();
                Console.Write("Please enter the dog's breed: ");
                newDog.Breed = Console.ReadLine();
                Console.Write("Please enter the dog's shelter ID: ");
                newDog.ShelterAssignedID = Console.ReadLine();
                Console.Write("Please enter the dog's weight: ");
                newDog.Weight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the dog's gender: ");
                newDog.Gender = Console.ReadLine();
                Console.Write("Please enter an image url: ");
                newDog.ImageLink = Console.ReadLine();
                Console.Write("Please enter a video url: ");
                newDog.VideoLink = Console.ReadLine();


               
                Console.Clear();
               

                //Dog's quiz results
                newDog.getDogQuizResults();
                dogList.Add(newDog);
                Console.Write("");



                Console.Write("Would you like to add another dog? Yes or No: ");
                newDogAnswer = Console.ReadLine().ToUpper();

            }
            Console.Write("All changes have been saved!");

            Console.Clear();

            List<Person> personList = new List<Person>();
            //create a person who wants to adopt
            Person person = new Person();
            
            person.getPersonQuizResults();
            personList.Add(person);

            
            #region topsecrethiddencode
           

            #region Bert
            Dog dog1 = new Dog();
            dog1.Name = "Bert";
            dog1.Breed = "Beagle";
            dog1.Age = 5;
            dog1.Gender = "Male";
            dog1.Weight = 33;
            dog1.ZipCode = "63139";
            dog1.ShelterAssignedID = "A1234";
            dog1.ShelterID = 1;
            dog1.ImageLink = @"http://2.bp.blogspot.com/-6LhWFm9d0v4/TmXl46Vr1zI/AAAAAAAAA4Y/RH4EL979trk/s1600/Beagle3.jpg";
            dog1.VideoLink = @"https://www.youtube.com/watch?v=657k8koX4U4#action=share";
            dog1.Trainability = 1;
            dog1.HumanSocialability = 2;
            dog1.Affection = 2;
            dog1.AnimalSocialability = 1;
            dog1.Energy = 1;

            dogList.Add(dog1);

            #endregion Bert
            #region Fido
            Dog dog2 = new Dog();
            dog1.Name = "Fido";
            dog1.Breed = "Golden Retriever";
            dog1.Age = 2;
            dog1.Gender = "Male";
            dog1.Weight = 45;
            dog1.ZipCode = "63108";
            dog1.ShelterAssignedID = "A2345";
            dog1.ShelterID = 1;
            dog1.ImageLink = @"http://2.bp.blogspot.com/-6LhWFm9d0v4/TmXl46Vr1zI/AAAAAAAAA4Y/RH4EL979trk/s1600/Beagle3.jpg";
            dog1.VideoLink = @"https://www.youtube.com/watch?v=657k8koX4U4#action=share";
            dog1.Trainability = 3;
            dog1.HumanSocialability = 3;
            dog1.Affection = 3;
            dog1.AnimalSocialability = 3;
            dog1.Energy = 3;

            dogList.Add(dog1);

            #endregion Fido
            #region Tina
            Dog dog3 = new Dog();
            dog3.Name = "Tina";
            dog3.Breed = "Chihuahua";
            dog3.Age = 12;
            dog3.Gender = "Female";
            dog3.Weight = 7;
            dog3.ZipCode = "63139";
            dog3.ShelterAssignedID = "A1111";
            dog3.ShelterID = 1;
            dog3.ImageLink = @"http://2.bp.blogspot.com/-6LhWFm9d0v4/TmXl46Vr1zI/AAAAAAAAA4Y/RH4EL979trk/s1600/Beagle3.jpg";
            dog3.VideoLink = @"https://www.youtube.com/watch?v=657k8koX4U4#action=share";
            dog3.Trainability = 1;
            dog3.HumanSocialability = 1;
            dog3.Affection = 1;
            dog3.AnimalSocialability = 1;
            dog3.Energy = 2;

            dogList.Add(dog3);

            #endregion Tina
            #region George
            Dog dog4 = new Dog();
            dog4.Name = "George";
            dog4.Breed = "Miniature Poodle";
            dog4.Age = 3;
            dog4.Gender = "Male";
            dog4.Weight = 16;
            dog4.ZipCode = "63130";
            dog4.ShelterAssignedID = "A4567";
            dog4.ShelterID = 1;
            dog4.ImageLink = @"http://2.bp.blogspot.com/-6LhWFm9d0v4/TmXl46Vr1zI/AAAAAAAAA4Y/RH4EL979trk/s1600/Beagle3.jpg";
            dog4.VideoLink = @"https://www.youtube.com/watch?v=657k8koX4U4#action=share";
            dog4.Trainability = 3;
            dog4.HumanSocialability = 3;
            dog4.Affection = 3;
            dog4.AnimalSocialability = 3;
            dog4.Energy = 3;

            dogList.Add(dog4);

            #endregion George
            #region Sparky
            Dog dog5 = new Dog();
            dog5.Name = "Sparky";
            dog5.Breed = "Dauschund";
            dog5.Age = 8;
            dog5.Gender = "Female";
            dog5.Weight = 23;
            dog5.ZipCode = "63139";
            dog5.ShelterAssignedID = "A12777";
            dog5.ShelterID = 1;
            dog5.ImageLink = @"http://2.bp.blogspot.com/-6LhWFm9d0v4/TmXl46Vr1zI/AAAAAAAAA4Y/RH4EL979trk/s1600/Beagle3.jpg";
            dog5.VideoLink = @"https://www.youtube.com/watch?v=657k8koX4U4#action=share";
            dog5.Trainability = 2;
            dog5.HumanSocialability = 2;
            dog5.Affection = 2;
            dog5.AnimalSocialability = 3;
            dog5.Energy = 1;

            dogList.Add(dog5);

            #endregion Bert
            #region Roberta
            Dog dog6 = new Dog();
            dog6.Name = "Roberta";
            dog6.Breed = "Fox Terrier";
            dog6.Age = 3;
            dog6.Gender = "Female";
            dog6.Weight = 15;
            dog6.ZipCode = "63139";
            dog6.ShelterAssignedID = "A2534";
            dog6.ShelterID = 1;
            dog6.ImageLink = @"http://2.bp.blogspot.com/-6LhWFm9d0v4/TmXl46Vr1zI/AAAAAAAAA4Y/RH4EL979trk/s1600/Beagle3.jpg";
            dog6.VideoLink = @"https://www.youtube.com/watch?v=657k8koX4U4#action=share";
            dog6.Trainability = 2;
            dog6.HumanSocialability = 3;
            dog6.Affection = 3;
            dog6.AnimalSocialability = 3;
            dog6.Energy = 3;

            dogList.Add(dog6);

            #endregion Roberta
            #region Jeff
            Dog Dog7 = new Dog();
            Dog7.Name = "Jeff";
            Dog7.Breed = "Corgi";
            Dog7.Age = 1;
            Dog7.Gender = "Male";
            Dog7.Weight = 23;
            Dog7.ZipCode = "63108";
            Dog7.ShelterAssignedID = "A4578";
            Dog7.ShelterID = 1;
            Dog7.ImageLink = @"http://2.bp.blogspot.com/-6LhWFm9d0v4/TmXl46Vr1zI/AAAAAAAAA4Y/RH4EL979trk/s1600/Beagle3.jpg";
            Dog7.VideoLink = @"https://www.youtube.com/watch?v=657k8koX4U4#action=share";
            Dog7.Trainability = 2;
            Dog7.HumanSocialability = 3;
            Dog7.Affection = 3;
            Dog7.AnimalSocialability = 3;
            Dog7.Energy = 3;

            dogList.Add(Dog7);

            #endregion Jeff
            #region Amy
            Dog dog8 = new Dog();
            dog8.Name = "Amy";
            dog8.Breed = "Poodle";
            dog8.Age = 8;
            dog8.Gender = "Female";
            dog8.Weight = 63;
            dog8.ZipCode = "63139";
            dog8.ShelterAssignedID = "A5784";
            dog8.ShelterID = 1;
            dog8.ImageLink = @"http://2.bp.blogspot.com/-6LhWFm9d0v4/TmXl46Vr1zI/AAAAAAAAA4Y/RH4EL979trk/s1600/Beagle3.jpg";
            dog8.VideoLink = @"https://www.youtube.com/watch?v=657k8koX4U4#action=share";
            dog8.Trainability = 3;
            dog8.HumanSocialability = 2;
            dog8.Affection = 1;
            dog8.AnimalSocialability = 1;
            dog8.Energy = 3;
            dogList.Add(dog8);
            #endregion Amy
            #region Scruffles
            Dog dog9 = new Dog();
            dog9.Name = "Scruffles";
            dog9.Breed = "Pit Bull";
            dog9.Age = 4;
            dog9.Gender = "Male";
            dog9.Weight = 43;
            dog9.ZipCode = "63139";
            dog9.ShelterAssignedID = "A1254";
            dog9.ShelterID = 1;
            dog9.ImageLink = @"http://2.bp.blogspot.com/-6LhWFm9d0v4/TmXl46Vr1zI/AAAAAAAAA4Y/RH4EL979trk/s1600/Beagle3.jpg";
            dog9.VideoLink = @"https://www.youtube.com/watch?v=657k8koX4U4#action=share";
            dog9.Trainability = 3;
            dog9.HumanSocialability = 3;
            dog9.Affection = 3;
            dog9.AnimalSocialability = 3;
            dog9.Energy = 3;

            dogList.Add(dog9);
            #endregion Scruffles
            #region PitBull
            Dog dog10 = new Dog();
            dog10.Name = "PitBull";
            dog10.Breed = "Pit Bull";
            dog10.Age = 10;
            dog10.Gender = "Male";
            dog10.Weight = 53;
            dog10.ZipCode = "63139";
            dog10.ShelterAssignedID = "A1534";
            dog10.ShelterID = 1;
            dog10.ImageLink = @"http://2.bp.blogspot.com/-6LhWFm9d0v4/TmXl46Vr1zI/AAAAAAAAA4Y/RH4EL979trk/s1600/Beagle3.jpg";
            dog10.VideoLink = @"https://www.youtube.com/watch?v=657k8koX4U4#action=share";
            dog10.Trainability = 3;
            dog10.HumanSocialability = 3;
            dog10.Affection = 3;
            dog10.AnimalSocialability = 3;
            dog10.Energy = 1;

            dogList.Add(dog10);

            #endregion PitBull
            #endregion topsecrethiddencode

            Console.Clear();
            //match things here!
            
            
            MatchMaker();


            void MatchMaker()
            {
                foreach (var dog in dogList)
                {
                    decimal c = 0; //compatibility score
                    {

                        if (person.Affection == dog.Affection)
                        {
                            c = c + 1;
                        }
                        if (person.AnimalSocialability == dog.AnimalSocialability)
                        {
                            c = c + 1;
                        }
                        if (person.HumanSocialability == dog.HumanSocialability)
                        {
                            c = c + 1;
                        }
                        if (person.Energy == dog.Energy)
                        {
                            c = c + 1;
                        }
                        if (person.Trainability == dog.Trainability)
                        {
                            c = c + 1;
                        }
                    }

                    dog.Compatibility = (c / 5 * 100);


                }
              ;

                List<Dog> matchList = new List<Dog>();
                matchList = dogList.OrderByDescending(x => x.Compatibility).Take(6).ToList();

                Console.WriteLine("Congratulations! Your Top 6 Wag Mates are: \n");
      
                foreach (var dog in matchList)
                {
                    Console.WriteLine("{0}  \n{1}  \n{2:%%} \n", dog.Name, dog.Gender, dog.Compatibility + "% Compatibility");
                }



                Console.ReadLine();
            }
        }
    }


}

