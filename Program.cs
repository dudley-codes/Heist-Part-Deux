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

      Console.Clear();
      Console.WriteLine("Bank Heist, Part Deux");
      Console.WriteLine("Here are your current crew choices:");
      foreach (IRobber robber in rolodex)
      {
        Console.Write($"{robber.Name} is a {robber.Skill} and their skill level is {robber.SkillLevel}");
      }

    }
  }
}
