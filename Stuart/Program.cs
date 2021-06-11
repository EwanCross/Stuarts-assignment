using System;

namespace Stuart
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant p = new Participant();
            p.setName("Ewan");
            p.printParticipant();

            Team t = new Team();
            t.setName("Ewans team");
            t.addParticipant(p);
            t.printTeam();


        }
    }
}
