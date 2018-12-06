using System;

public static class Raindrops {
  public static string Convert (int number) {
    string retVal = string.Empty;

    if (number % 3 == 0) {
      retVal += "Pling";
    }
    if (number % 5 == 0) {
      retVal += "Plang";
    }
    if (number % 7 == 0) {
      retVal += "Plong";
    }
    if (retVal.Length == 0) {
      return number.ToString();
    }
    return retVal;
  }
}
