using Raiding.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public abstract class BaseHero : IBaseble
    {
        protected BaseHero(string name)
        {
            this.Name = name;
            
        }

        public string Name { get; }

        public virtual int Power { get; } = 0;

        public virtual string CastAbility()
        {
            return $"{ this.GetType().Name} - {this.Name} healed for { this.Power}";
        }
    }
}
