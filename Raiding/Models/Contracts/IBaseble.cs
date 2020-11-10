using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models.Contracts
{
  public  interface IBaseble
    {
        public string Name { get; }
        public int Power { get; }

        public abstract string CastAbility();

    }
}
