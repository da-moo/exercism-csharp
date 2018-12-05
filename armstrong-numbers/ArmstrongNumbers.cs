using System;
using System.Linq;

public static class ArmstrongNumbers {
  public static bool IsArmstrongNumber (int number) {
    var digits = number.ToString ().Select (i => int.Parse (i.ToString ()));
    int numOfDigits = digits.Count ();
    int armstrong = digits.Aggregate (0, (currentTotal, nextValue) =>
      currentTotal + (int) Math.Pow (nextValue, numOfDigits));
    return number == armstrong;
  }
}
