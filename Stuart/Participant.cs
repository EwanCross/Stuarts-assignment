using System;
using System.Collections.Generic;
using System.Text;

namespace Stuart
{
    class Participant
    {
        string personname;


        public void setName(String s)
        {
            this.personname = s;
        }


        public string getName()
        {
            return personname;
        }


        public void printParticipant()
        {
            Console.WriteLine("A participant called" + personname);


        }
    }
}
