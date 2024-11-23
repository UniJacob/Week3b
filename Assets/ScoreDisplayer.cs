using TMPro;
using TMPro.Examples;
using UnityEngine;

public class ScoreDisplayer : MonoBehaviour
{
    [SerializeField] TMP_Text Hits, Misses;
    void Update()
    {
        Hits.text = "Hits: " + InfoTracker.GetHits().ToString();
        Misses.text = "Misses: " + InfoTracker.GetMisses().ToString();
    }
}
