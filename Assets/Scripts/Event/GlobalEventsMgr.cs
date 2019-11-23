using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalEventsMgr 
{
    private static GlobalEventsMgr instance;
    public static GlobalEventsMgr GetInstance()
    {
        if (instance == null)
            instance = new GlobalEventsMgr();
        return instance;
    }
    /// <summary>
    /// 事件列表
    /// </summary>
    public Dictionary<ulong, EventEntity> m_dicAllEvents = new Dictionary<ulong, EventEntity>();
    //                                                                   

    /// <summary>
    /// 事件触发
    /// </summary>
    public void SendEvent(ulong Id, EventsType et, object param)
    {
        if (m_dicAllEvents.ContainsKey(Id))
        {

            if (m_dicAllEvents[Id].ContainsKey(et))
            {
                m_dicAllEvents[Id].GetValue(et)(param);
            }
            else
            {
                Debug.Log("没有监听这个事件:" + et);
            }
        }
        else
        {
            Debug.Log("没有监听这个ID:" + Id);
        }
    }

    /// <summary>
    /// 事件绑定
    /// </summary>
    public void RegEvent(ulong Id, EventsType et, CommonEvent attachEvent)
    {
        if (m_dicAllEvents.ContainsKey(Id))
        {

            if (m_dicAllEvents[Id].ContainsKey(et))
            {
                m_dicAllEvents[Id].SetValue(et, attachEvent);
            }
            else
            {
                m_dicAllEvents[Id].SetValue(et, attachEvent);
            }
        }
        else
        {
            m_dicAllEvents.Add(Id, new EventEntity());
            m_dicAllEvents[Id].SetValue(et, attachEvent);
        }
    }


    /// <summary>
    /// 去除事件绑定
    /// </summary>
    public void UnRegEvent(ulong Id, EventsType et)
    {
        if (m_dicAllEvents.ContainsKey(Id))
        {
            if (m_dicAllEvents[Id].ContainsKey(et))
            {
                m_dicAllEvents[Id].RemoveKey(et);
            }
            else
            {
                Debug.Log("没有监听这个事件:" + et);
            }
        }
        else
        {
            Debug.Log("没有监听这个ID:" + Id);
        }
    }
}

public class EventEntity
{
    public Dictionary<EventsType, CommonEvent> dict;
    public EventEntity()
    {
        dict = new Dictionary<EventsType, CommonEvent>();
    }
    public EventEntity(EventsType et, CommonEvent ce)
    {
        dict = new Dictionary<EventsType, CommonEvent>();
        if (dict.ContainsKey(et))
        {
            dict[et] = ce;
        }
        else
        {
            dict.Add(et, ce);
        }
    }

    public CommonEvent GetValue(EventsType et)
    {
        if (dict.ContainsKey(et))
        {
            return dict[et];
        }
        return null;
    }
    public void SetValue(EventsType et, CommonEvent ce)
    {
        if (dict.ContainsKey(et))
        {
            dict[et] = ce;
        }
        else
        {
            dict.Add(et, ce);
        }
    }
    public bool ContainsKey(EventsType et)
    {
        return dict.ContainsKey(et);
    }
    public bool RemoveKey(EventsType et)
    {
        if (ContainsKey(et))
        {
            return dict.Remove(et);
        }
        return false;
    }

}