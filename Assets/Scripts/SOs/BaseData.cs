using System;
using System.Collections.Generic;
using UnityEngine;

public class BaseData<T> : ScriptableObject
{

    public T Value;

    private readonly List<Action<T>> actions = new List<Action<T>>();

    public void OnChange(Action<T> action)
    {
        actions.Add(action);
    }

    protected void NotifyListeners(T value)
    {
        actions.ForEach(action => action(value));
    }

}
