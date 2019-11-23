using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TaskSystem;
using System;

namespace TaskSystem
{
    public class LogicCondition : ITaskCondition
    {
        protected bool m_IsFinish;
        public void Handle()
        {
        }

        public bool IsFinish()
        {
            return m_IsFinish;
        }

        public string Name()
        {
            return this.ToString();
        }

        public virtual void Start()
        {
        }
    }
}