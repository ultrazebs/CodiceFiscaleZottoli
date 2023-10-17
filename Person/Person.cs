using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    /// <summary>
    /// Manages personal information
    /// </summary>
    public class Person
    {

        #region " properties "
        //properties
        public enum GenderType
        {
            Male,
            Female,
            NotSpecified
        }

        public string FirstName;
        public string LastName;
        public DateTime BirthDate;
        public string BirthCity;
        public string BirthCountry;
        public GenderType Gender;
        
        #endregion

        #region " Constructors "
        /// <summary>
        /// Basic constructor
        /// </summary>
        public Person()
        {

        }

        /*
        public Person(string FirstName, string LastName, DateTime BirthDate, String BirthCity) : this(FirstName, LastName, BirthDate, BirthCity, BirthCountry, Person.GenderType.Male)
        {

        }
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FirstName"> First name of the person </param>
        /// <param name="LastName"> Last name of the person </param>
        /// <param name="BirthDate"> Birth date of the person </param>
        /// <param name="BirthCity"> Birth city of the person </param>
        /// <param name="Gender"> Gender of the person </param>
        public Person(string FirstName, string LastName, DateTime BirthDate, String BirthCity, GenderType Gender)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.BirthCity = BirthCity;
            this.Gender = Gender;
        }



        public Person(string FirstName, string LastName, DateTime BirthDate, string BirthCity, string BirthCountry, GenderType Gender)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.BirthCity = BirthCity;
            this.BirthCountry = BirthCountry;
            this.Gender = Gender;
        }


        #endregion


        #region " Methods "

        public string FiscalCode()
        {


            // variables
            string result, gender;
            if(this.Gender == GenderType.NotSpecified) {
                result = "";
            }
            else
            {
                if(this.Gender == GenderType.Male)
                {
                    gender = "M";
                }
                else
                {
                    gender = "F";
                }
            
            
                // create an instance of CodiceFiscale class
                // use CodiceFiscale class to generate the Fiscal code
                CodiceFiscaleUtility.CodiceFiscale FiscalCode;

                FiscalCode = new CodiceFiscaleUtility.CodiceFiscale(this.LastName, this.FirstName, gender, this.BirthDate, this.BirthCity, this.BirthCountry, 0);
                result = FiscalCode.CodiceNormalizzato;
            }

            return result;
        }

        public int Age()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - BirthDate.Year;

            // Check if the birthday has occurred this year
            if (BirthDate.Date > currentDate.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public int menu()
        {
            int choice;
            
            Console.WriteLine("Choose from the following options: ");
            Console.WriteLine("1) Register a new user: ");
            Console.WriteLine("2) Show Tax Code;");
            Console.WriteLine("3) Show age. ");
            Console.WriteLine("4) Show data. ");

            choice = Convert.ToInt32(Console.ReadLine());
            

            return choice;
        }
        
        public string genderInString()
        {
            if (this.Gender == GenderType.Male)
                return "Male";
            else
                return "Female";
        }

        public void Print()
        {
            Console.WriteLine("First Name: " + this.FirstName);
            Console.WriteLine("Last Name: " + this.LastName);
            Console.WriteLine("Birth Date: " + this.BirthDate);
            Console.WriteLine("Birth City: " + this.BirthCity);
            Console.WriteLine("Birth Country: " + this.BirthCountry);
            Console.WriteLine("Gender: " + this.genderInString());
            Console.WriteLine("Tax Code: " + this.FiscalCode());
        }
        
        #endregion
    }


}
