using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigator : MonoBehaviour
{
    public GameObject profilescene;
    public GameObject swipescenee;
    public GameObject matchesScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void profile()
    {
        profilescene.SetActive(true);
        swipescenee.SetActive(false);
        matchesScene.SetActive(false);
    }
    public void Matches()
    {
        profilescene.SetActive(false);
        swipescenee.SetActive(false);
        matchesScene.SetActive(true);

    }

    public void Swipe()
    {
        profilescene.SetActive(true);
        swipescenee.SetActive(true);
        matchesScene.SetActive(true);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
