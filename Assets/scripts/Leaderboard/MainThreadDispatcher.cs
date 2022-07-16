using System;
using System.Collections.Concurrent;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainThreadDispatcher : MonoBehaviour
{
    /*
    private static MainThreadDispatcher _shared;
    public static MainThreadDispatcher shared
    {
        get
        {
            if (_shared != null)
                return _shared;

            GameObject dispatcherObject = new GameObject("Main thread dispatcher");
            _shared = dispatcherObject.AddComponent<MainThreadDispatcher>();
            return _shared;
        }
    }
    
    private readonly ConcurrentQueue<Action> pendingActions = new ConcurrentQueue<Action>();

    void Awake()
    {
        if (_shared != null && _shared != this)
        {
            Destroy(this);
            return;
        }

        _shared = this;
        DontDestroyOnLoad(this);
    }

    public void Dispatch(Action action) => pendingActions.Enqueue(action);

    void Update()
    {
        while (pendingActions.TryDequeue(out Action pendingAction))
        {
            try
            {
                pendingAction();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
            }
        }
    }
    */
}
