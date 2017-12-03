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
        public dynamic Split(string fullName)
        {
            string[] words = fullName.Split(' ');
            return new
            {
                firstName = words[0],
                lastName = words[1]
            };
        }
    }


}
