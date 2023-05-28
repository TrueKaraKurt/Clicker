using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class ObjPool<T> where T : MonoBehaviour
{
    public T prefab { get; }
    public bool isAutoExpandble { get; set; }
    public Transform container { get; }

    private List<T> pool;

    public ObjPool(T prefab, int count)
    {
        this.prefab = prefab;
        container = null;
    }
    public ObjPool(T prefab, int count, Transform container)
    {
        this.prefab = prefab;
        this.container = container;

        CreatePool(count);
    }
    private void CreatePool(int count)
    {
        pool = new List<T>();

        for (int i = 0; i < count; i++)
        {
            CreateObject();
        }
    }

    private T CreateObject(bool isActiveByDefault = false)
    {
        T createdObject = Object.Instantiate(prefab, container);
        createdObject.gameObject.SetActive(isActiveByDefault);
        pool.Add(createdObject);
        return createdObject;
    }

    public bool HasFreeElement(out T element)
    {
        foreach (T obj in pool)
        {
            if (!obj.gameObject.activeInHierarchy)
            {
                element = obj;
                obj.gameObject.SetActive(true);
                return true;
            } 
        }
        element = null;
        return false;
    }
    public T GetFreeElement()
    {
        if (HasFreeElement(out T element))
        {
            return element;
        }
        if (isAutoExpandble)
        {
            return CreateObject(true);
        }
        throw new Exception($"No elements in pool of type {typeof(T)}");
    }
}

