using UnityEngine;
using admob;

public class AdManager : MonoBehaviour
{
    public static AdManager Instance { set; get; }

    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        Admob.Instance().initAdmob("ca-app-pub-3434350452315640/4742139818", "ca-app-pub-3434350452315640/5667032613");
        Admob.Instance().loadInterstitial();
        Admob.Instance().setTesting(true);
    }

    public static void ShowTopBanner()
    {
        Admob.Instance().showBannerRelative(AdSize.HugeBanner, AdPosition.TOP_CENTER, 0);
    }

    public static void ShowVideoAd()
    {
        Admob.Instance().showBannerRelative(AdSize.HugeBanner, AdPosition.TOP_CENTER, 0);
    }
}
