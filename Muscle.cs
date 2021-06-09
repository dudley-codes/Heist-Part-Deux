using System;

namespace HeistPartDeux
{
  public class Muscle : IRobber
  {
    public string Name { get; set; }
    public string Skill { get; set; } = "Muscle (disarms guards)";
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }
    public void PerformSkill(Bank bank)
    {
      bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;

      Console.WriteLine($"{Name} is fighting the security guards. Decreased security by {SkillLevel}");

      if (bank.SecurityGuardScore <= 0)
      {
        Console.WriteLine($"{Name} just kicked the security guard's ass!");
      }

    }
    public void AddMuscle(string name, int skillLevel, int percent)
    {
      Name = name;
      Skill = "Muscle (disarms guards)";
      SkillLevel = skillLevel;
      PercentageCut = percent;
    }
  }
}