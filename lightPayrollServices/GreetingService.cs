using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lightPayrollServices
{
    public class GreetingService
    {
        private static Random rand = new Random();

        private string[] adminGreetings =
        {
            "Protecting people was never an easy job!",
            "Wear hoodie and let's type faster ;>",
            "Welcome back! Ready to maintain stuff?"

        };

        private string[] christCenteredGuidance =
        {
            "Come to me, all you who are weary,\n and I will give you rest. — Matthew 11:28",
            "Abide in me, and I in you. — John 15:4",

            // Beatitudes
            "Blessed are the poor in spirit,\n for theirs is the kingdom of heaven. — Matthew 5:3",
            "Blessed are those who mourn,\n for they shall be comforted. — Matthew 5:4",
            "Blessed are the meek,\n for they shall inherit the earth. — Matthew 5:5",
            "Blessed are those who hunger and thirst for righteousness,\n for they shall be satisfied. — Matthew 5:6",
            "Blessed are the merciful,\n for they shall receive mercy. — Matthew 5:7",
            "Blessed are the pure in heart,\n for they shall see God. — Matthew 5:8",
            "Blessed are the peacemakers,\n for they shall be called children of God. — Matthew 5:9",
            "Take heart! I have overcome the world. — John 16:33",
            "Believe in the Lord Jesus, and you will be saved. — Acts 16:31"
        };


        public string GetRandomGreeting(string role)
        {
            if (role == "Admin") return adminGreetings[rand.Next(adminGreetings.Length)];
            else if (role == "Christ-Centered Guidance") return christCenteredGuidance[rand.Next(christCenteredGuidance.Length)];
            

            return "Hello!";
        }
    }
}
