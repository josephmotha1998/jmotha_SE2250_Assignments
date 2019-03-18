using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareOnTwitter : MonoBehaviour
{
    private string _twitter_address = "https://twitter.com/intent/tweet";

    private string _tweet_language = "en";

    private string _displaytext = "Check out my new score: ";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Share()
    {
        Application.OpenURL(_twitter_address + "?text=" + WWW.EscapeURL(_displaytext) + ScoreManager.HIGH_SCORE + "&amp;lang=" + WWW.EscapeURL(_tweet_language));
    }
}
