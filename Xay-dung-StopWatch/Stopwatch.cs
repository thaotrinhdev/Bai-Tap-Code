class Stopwatch
{
    public DateTime startTime= DateTime.Now;
    public DateTime endTime;
    //Setter
    private DateTime StartTime=>startTime;
    private DateTime EndTime=>endTime;
    public void Start ()
    {
        startTime=DateTime.Now;

    }
    public void Stop()
    {
        startTime=DateTime.Now;
    }
    // Thời Gian trải qua
    // TimeSpan: Khoảng thời gian
    public TimeSpan GetEplapsed(DateTime endtime, DateTime starttime)
    {
        TimeSpan timeSpan = endtime-starttime;
        return timeSpan;
    }
    //Getter
    public DateTime SetEndTime()
    {
        return endTime;
    }
    public DateTime SetStartTime()
    {
        return startTime;
    }
    
    
}