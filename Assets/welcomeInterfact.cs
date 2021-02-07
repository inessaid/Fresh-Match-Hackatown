using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class welcomeInterfact : MonoBehaviour
{
    public GameObject welcome1;
    public GameObject welcome2;

    // Start is called before the first frame update
    void Start()
    {
        welcome1.SetActive(true);
        welcome2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Accept()
    {
        welcome1.SetActive(false);
        welcome2.SetActive(true);
    }

    public void CreateAccount()
    {
        SceneManager.LoadScene("Sign-Up");
    }
}
