//
// You should use a class which represents a threading job. This class will be initialized by the Unity main thread. 
// Then you start a worker thread on a function of that class and let it do it's job.
// 
// Here's the important part: You of course store this job somewhere on the Unity side and have the Update loop (or a coroutine) 
// continously checking an "isDone" variable in your class which will be set by the worker thread when it's finished and when it 
// stored all data it produced. It's important that you make the access to this isDone boolean thread safe since both threads will 
// need to access it.

//Unfortunately you can't use lock on value types like a bool, so you need 
//any kind of reference type as lock handle. I've made a small "framework" for a threaded job:

 public class ThreadTest1
{
    private bool m_IsDone = false;
    private object m_Handle = new object();
    private System.Threading.Thread m_Thread = null;
    public bool IsDone
    {
        get
        {
            bool tmp;
            lock (m_Handle)
            {
                tmp = m_IsDone;
            }
            return tmp;
        }
        set
        {
            lock (m_Handle)
            {
                m_IsDone = value;
            }
        }
    }
 
    public virtual void Start()
    {
        m_Thread = new System.Threading.Thread(Run);
        m_Thread.Start();
    }
    public virtual void Abort()
    {
        m_Thread.Abort();
    }
 
    protected virtual void ThreadFunction() { }
 
    protected virtual void OnFinished() { }
 
    public virtual bool Update()
    {
        if (IsDone)
        {
            OnFinished();
            return true;
        }
        return false;
    }
    private void Run()
    {
        ThreadFunction();
        IsDone = true;
    }
}

//This should server as base class. 
//Just create a Job class which overrides the ThreadFunction function and implement your code.
