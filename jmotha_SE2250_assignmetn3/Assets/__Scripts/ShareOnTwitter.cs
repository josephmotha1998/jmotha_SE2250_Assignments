using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareOnTwitter : MonoBehaviour
{
    string twitter_address = "https://twitter.com/intent/tweet";

    string tweet_language = "en";

    string displaytext = "Check out my new score: ";

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
        Application.OpenURL(twitter_address + "?text=" + WWW.EscapeURL(displaytext) + ScoreManager.HIGH_SCORE + "&amp;lang=" + WWW.EscapeURL(tweet_language));
    }
}
