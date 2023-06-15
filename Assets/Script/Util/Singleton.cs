using System;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;
    
	public static T Instance
	{
		get
		{
			if (applicationIsQuitting)
			    return null;

            if (_instance != null) return _instance;

            _instance = FindObjectOfType(typeof(T)) as T;

            if (_instance != null) return _instance;

            GameObject singleton = new GameObject();
            _instance = singleton.AddComponent<T>();
            DontDestroyOnLoad(singleton);
			return _instance;
        }
	}

	private static bool applicationIsQuitting = false;

	protected virtual void OnDestroy()
	{
        ResetInstance();
    }

	public static void ResetInstance()
	{
		_instance = null;
		applicationIsQuitting = false;
	}

    public static bool HasInstance()
    {
        return (_instance != null);
    }
}