using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SkillSystem
{
    public interface IInterrupt
    {
        void Handle(Entity entity);
    }
}