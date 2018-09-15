using System;

namespace Dog
{
    class Dog
    {

        public string name;
        public string owner;
        public int age;
        public enum Gender
        {
            Male, Female
        }
        public Gender gender;
        public Dog(string dogname, string ownername, int dogage, Gender doggender)
        {
            name = dogname;
            owner = ownername;
            age = dogage;
            gender = doggender;

        }

        public void bark(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Woof!");

            }
            Console.WriteLine();
        }

        public string getTag()
        {
            string MF;
            if (gender == Gender.Female)
            {
                MF = "Her";
            }
            else
            {
                MF = "His";
            }
            string HS;
            if (MF == "Her")
            {
                HS = "she";
            }
            else
            {
                HS = "he";
            }
            return ("If lost, call " + owner + ". " + MF + " name is " + name + " and " + HS + " is " + age + " years old." );
            
        }
    

static void Main(string[] args)
{
    Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
    puppy.bark(3); // output: Woof!Woof!Woof!
    Console.WriteLine(puppy.getTag());
}



    }
}





