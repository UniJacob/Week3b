using UnityEngine;

public static class InfoTracker
{
    private static int TargetsHit = 0, TargetsMissed = 0;
    public static void addHit()
    {
        ++TargetsHit;
    }
    public static void addMiss()
    {
        ++TargetsMissed;
    }

    public static int GetHits()
    {
        return TargetsHit;
    }
    public static int GetMisses()
    {
        return TargetsMissed;
    }
}
