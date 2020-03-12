using UnityEngine;
using UnityEngine.Analytics;

public class DisableAnalytics
{
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        Analytics.initializeOnStartup = false;
        Analytics.limitUserTracking = true;
        Analytics.deviceStatsEnabled = false;
        Analytics.enabled = false;
    }
}
