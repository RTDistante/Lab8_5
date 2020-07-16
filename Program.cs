using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Lab8_5
{
    class Application
    {
        public string firstName;
        public string lastName;
        public string dateOfBirth;
        public string address;
        public string city;
        public string state;
        public int zipCode;
        public string phoneNumber;
        public string email;
        public bool isSubmitted;
        public bool isAccepted;

        public Application(string first, string last, string dob, string address, string city, string state, int zip, string phone, string email) 
        {
            this.firstName = first;
            this.lastName = last;
            this.dateOfBirth = dob;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zip;
            this.phoneNumber = phone;
            this.email = email;
            isSubmitted = false;
            isAccepted = false;
        }

        public void Submit()
        {
            isSubmitted = true;
            Console.WriteLine("Application has been submitted.");
        }

        public virtual void Accept()
        {
            isAccepted = true;
            Console.WriteLine("Application Accepted!");
        }
    }


    class DreamHouseHunter: Application
    {
        public string jobTitle;
        public int currentAnnualIncome;
        public int whenBuy;
        public int bedrooms;
        public int bathrooms;

        public DreamHouseHunter(string job, int income, int when, int bedrooms, int bathrooms, string first, string last, string dob, string address, string city, string state, int zip, string phone, string email) : base(first, last, dob, address, city, state, zip, phone, email)
        {
            this.jobTitle = job;
            this.currentAnnualIncome = income;
            this.whenBuy = when;
            this.bedrooms = bedrooms;
            this.bathrooms = bathrooms;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Dream House Hunters!");
        }
    }

    class ParadiseIsland: Application
    {
        public string gender;
        public string dateName;
        public int dateYears;

        public ParadiseIsland(string gender, string dateName, int dateYears, string first, string last, string dob, string address, string city, string state, int zip, string phone, string email) : base(first, last, dob, address, city, state, zip, phone, email)
        {
            this.gender = gender;
            this.dateName = dateName;
            this.dateYears = dateYears;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Paradise Island!");
        }
    }

    class AboveDeck: Application
    {
        public int boatingYears;
        public string nationality;

        public AboveDeck(int boatingYears, string nationality, string first, string last, string dob, string address, string city, string state, int zip, string phone, string email) : base(first, last, dob, address, city, state, zip, phone, email)
        {
            this.boatingYears = boatingYears;
            this.nationality = nationality;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Above Deck!");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DreamHouseHunter dhhContestant = new DreamHouseHunter("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith", "02/04/1975", "111 Bravo Way", "Los Angeles", "California", 90001, "888 - 233 - 1234", "omar.smith @hotmail.com");

            ParadiseIsland piContestant = new ParadiseIsland("Female", "Carl", 2, "Patti", "Johnson", "05/04/1994", "211 Love Rd", "Los Angeles", "California", 90001, "988 - 444", "1234patti.johnson@gmail.com");

            AboveDeck adContestant = new AboveDeck(20, "American", "Captain", "Lee", "07/12/1964", "311 Bravo Way", "Los Angeles", "California", 90001, "711 - 333 - 1234", "captain@gmail.com");

            dhhContestant.Submit();
            dhhContestant.Accept();

            piContestant.Submit();
            piContestant.Accept();

            adContestant.Submit();
            adContestant.Accept();
        }
    }
}
