namespace HeistPartDeux
{
  public interface IRobber
  {
    string Name { get; set; }
    string Skill { get; set; }
    int SkillLevel { get; set; }
    int PercentageCut { get; set; }
    void PerformSkill(Bank bank);
  }
}