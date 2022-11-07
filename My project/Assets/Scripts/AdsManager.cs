using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    string gameId = "5001231";
    bool testMode = true;

    private void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }

    public void ShowAd()
    {
        Advertisement.Show();
    }
}
