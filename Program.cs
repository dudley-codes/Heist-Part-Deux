using System;
using System.Collections.Generic;

namespace HeistPartDeux
{
  class Program
  {
    static void Main(string[] args)
    {
      Bank usaa = new Bank();
      usaa.CashOnHand = 1000000;
      usaa.BankName = "USAA";
      usaa.AlarmScore = 10;
      usaa.VaultScore = 0;
      usaa.SecurityGuardScore = 0;

      // usaa.checkIsSecure();

      LockSpecialist bob = new LockSpecialist();
      bob.Name = "Bob";
      bob.SkillLevel = 45;
      bob.PercentageCut = 15;

      Muscle george = new Muscle();
      george.Name = "George";
      george.SkillLevel = 90;
      george.PercentageCut = 40;

      Muscle jon = new Muscle();
      jon.Name = "Jon";
      jon.SkillLevel = 30;
      jon.PercentageCut = 15;

      LockSpecialist cleo = new LockSpecialist();
      cleo.Name = "Cleo";
      cleo.SkillLevel = 85;
      cleo.PercentageCut = 50;

      LockSpecialist sal = new LockSpecialist();
      sal.Name = "Sal";
      sal.SkillLevel = 20;
      sal.PercentageCut = 5;

      Hacker joshua = new Hacker();
      joshua.Name = "Joshua";
      joshua.SkillLevel = 90;
      joshua.PercentageCut = 60;

      List<IRobber> rolodex = new List<IRobber>();
      rolodex.Add(bob);
      rolodex.Add(joshua);
      rolodex.Add(sal);
      rolodex.Add(cleo);
      rolodex.Add(jon);
      rolodex.Add(george);

      Console.Clear();
      Console.WriteLine("Bank Heist, Part Deux");
      Console.WriteLine($"You have {rolodex.Count} hardened criminals to choose from.");
      GetNewRobber();
      // foreach (IRobber robber in rolodex)
      // {
      //   Console.Write($"{robber.Name} is a {robber.Skill} and their skill level is {robber.SkillLevel}.");
      // }

    }
    public void GetNewRobber()
    {
      bool addNew = false;
      string newName;
      string newSkill;
      int newSkillLevel;
      int newPercentage;

      Console.Write("Would you like to add a robber to your crew? (Y/N): ");

      if (Console.ReadLine().ToLower() == "y")
      {
        addNew = true;
      }

      if (addNew == true)
      {
        Console.Write("Please enter a name for a new crew member: ");
        newName = Console.ReadLine();
        Console.WriteLine(@"
1. Hacker (Disables Alarms)
2. Muscle (Disarms Guards)
3. Lock Specialist (Cracks Vault) ");
        Console.WriteLine("---------------------------");
        Console.Write(@"Select a Skill (1/2/3): ");

        newSkill = Console.ReadLine();

        Console.Write("Please enter a skill level: ");
        newSkillLevel = int.Parse(Console.ReadLine());
        Console.Write("Enter percentage cut: ");
        newPercentage = int.Parse(Console.ReadLine());
        switch (newSkill)
        {
          case "1":
            Hacker newbieHacker = new Hacker();

            return newbieHacker;
            break;
          case "2":
            Muscle newbieMuscle = new Muscle();
            newbieMuscle.AddMuscle(newName, newSkillLevel, newPercentage);
            return newbieMuscle;
            break;
          case "3":
            LockSpecialist newbieLock = new LockSpecialist();
            newbieLock.AddLockSpecialist(newName, newSkillLevel, newPercentage);
            return newbieLock;
            break;
          default:
            break;
        }

        GetNewRobber();
      }

    }

    public void AddNewRobber()
    {
    }
  }
}
