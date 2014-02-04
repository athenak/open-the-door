//This is how you would use the job class:

Job myJob;
void Start ()
{
    myJob = new Job();
    myJob.InData = new Vector3[10];
 
    myJob.Start(); // Don't touch any data in the job class after you called Start until IsDone is true.
}
 
void Update()
{
    if (myJob != null)
    {
        if (myJob.Update())
        {
            // Alternative to the OnFinished callback
            myJob = null;
        }
    }
}
