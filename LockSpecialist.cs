using System;

namespace HeistPartDeux
{
  public class LockSpecialist : IRobber
  {
    public string Name { get; set; }
    public string Skill { get; set; } = "Lock Specialist (cracks vault)";
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }
    public void PerformSkill(Bank bank)
    {
      bank.VaultScore = bank.VaultScore - SkillLevel;

      Console.WriteLine($"{Name} is trying to crack the safe. Decreased security by {SkillLevel}");

      if (bank.VaultScore <= 0)
      {
        Console.WriteLine($"{Name} just cracked the safe!");
      }
    }

    public void AddLockSpecialist(string name, int skillLevel, int percent)
    {
      Name = name;
      Skill = "Lock Specialist (cracks vault)";
      SkillLevel = skillLevel;
      PercentageCut = percent;
    }
  }
}