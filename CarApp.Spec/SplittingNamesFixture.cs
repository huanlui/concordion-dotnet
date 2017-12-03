using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Concordion.Runners.NUnit;

namespace CarApp.Spec
{
  [TestFixture]
    public class SplittingNamesFixture : ExecutableSpecification
    {
        public Result Split(string fullName)
        {
            Result result = new Result();
            string[] words = fullName.Split(' ');
            result.firstName = words[0];
            result.lastName = words[1];
            return result;
        }
    }

    public class Result
    {
        public string firstName;
        public string lastName;
    }
}
