using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TaskSystem;

public class TestTask : MonoBehaviour {
    Queue<TaskSystem.Task> taskQueue = new Queue<TaskSystem.Task>();
    public Button btn;
    TaskSystem.Task curTask;

    IEnumerator Start () {
        TaskSystem.Task task1 = new TaskSystem.Task("第一个任务 时间任务，间隔两秒", new TimeCondition(5.0f));
        TaskManager.Instance().AddTask(task1);
        TaskSystem.Task task2 = new TaskSystem.Task("第二个任务 次数任务，3", new TimesCondition(3));
        TaskSystem.Task task3 = new TaskSystem.Task("第三个任务 点击按钮",  new TirggerCondition(btn));
        TaskManager.Instance().AddTask(task2);
        TaskManager.Instance().AddTask(task3);

        curTask = TaskManager.Instance().Next();
        while (curTask!=null)
        {
            yield return curTask;
            Debug.Log(curTask.m_Name + " 已经做完了");
            curTask = TaskManager.Instance().Next();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 100), "click")) {
            curTask.Condition.Handle();
        }
    }
}
