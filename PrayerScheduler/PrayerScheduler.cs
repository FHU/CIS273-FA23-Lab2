namespace PrayerScheduler;

public class PrayerScheduler
{

    public int NumDailyPrayers => DailyPrayers.Count;
    public int NumNonDailyPrayers => NonDailyPrayers.Count;

    public List<Prayer> DailyPrayers { get; } = new();

    public List<Prayer> NonDailyPrayers
    {
        get;
    }

    public List<Prayer> AnsweredPrayers { get; } = new();

    public PrayerScheduler()
    {
    }

    public void AddPrayer(Prayer prayer)
    {
              
    }

    public void AnswerPrayer(int id)
    {
        
    }

    public List<Prayer> GetPrayers(int numPrayers)
    {
        List<Prayer> prayers = new List<Prayer>();

        return prayers;
    }

}


