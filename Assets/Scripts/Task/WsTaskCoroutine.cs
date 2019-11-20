using UnityEngine;
using System.Collections;
using System;

namespace Task
{
    public class WsTaskCoroutine : MonoBehaviour
    {
         
        private WsTaskManager m_tm;
        private Action m_Complate;
        private string m_QueueName;
        public void HandleQueue(WsTaskManager tm,string queueName, Action complate)
        {
            this.m_tm = tm;
            this.m_QueueName = queueName;
            this.m_Complate = complate;
            StartCoroutine(Handle());
        }

        protected IEnumerator Handle()
        {
            Task current = m_tm.Next();
            while (current != null)
            {
                Debug.Log(string.Format("当前执行的任务序列{0}, 当前任务{1}", this.m_QueueName, current.m_Name));
                yield return current;
                current = m_tm.Next();
            }
            StopAllCoroutines();
            Debug.Log(string.Format("结束: 任务序列{0}", this.m_QueueName));
            if (m_Complate != null)
            {
                m_Complate();
            }
        }



    }
}