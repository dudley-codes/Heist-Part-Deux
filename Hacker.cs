using System;

namespace HeistPartDeux
{
  public class Hacker : IRobber
  {
    public string Name { get; set; }
    public string Skill { get; set; } = "Hacker (disables alarms)";
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }
    public void PerformSkill(Bank bank)
    {
      bank.AlarmScore = bank.AlarmScore - SkillLevel;

      Console.WriteLine($"{Name} is attempting to hack the alarm system. Decreased security by {SkillLevel}");

      if (bank.AlarmScore <= 0)
      {
        Console.WriteLine($"{Name} just disabled the alarm!");
      }
    }
  }
}