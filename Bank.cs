using System;

namespace HeistPartDeux
{
  public class Bank
  {
    public int CashOnHand { get; set; }
    public int AlarmScore { get; set; }
    public int VaultScore { get; set; }
    public int SecurityGuardScore { get; set; }
    public string BankName { get; set; }
    public bool IsSecure { get; set; }

    public void checkIsSecure()
    {
      if (SecurityGuardScore <= 0 & AlarmScore <= 0 & VaultScore <= 0)
      {
        IsSecure = false;
        Console.WriteLine($"{BankName} is not secure.");
      }
      else
      {
        IsSecure = true;
        Console.WriteLine($"{BankName} is secure.");
      }
    }

  }
}