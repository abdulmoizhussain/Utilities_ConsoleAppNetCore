using System;
using Utilities_ConsoleAppNetCore.Utils;

namespace Utilities_ConsoleAppNetCore
{
  class Program
  {
    static void Main(string[] args)
    {
      // usages:
      var dateTime = DateTime.Parse("2022-01-22T12:33:15.672");

      long millis = dateTime.GetMillisSince1970();
      // Result of the method GetMillisSince1970:
      // must be equal to Javascript's 'new Date("2022-01-22T12:33:15.672").getTime();'
    }
  }
}
