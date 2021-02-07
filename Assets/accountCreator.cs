using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Firebase.Firestore;
using Firebase.Extensions;

public class accountCreator : MonoBehaviour
{
    public GameObject initialScene;
    public GameObject buyerScene1;
    public GameObject BusinessOwner;
    public GameObject produce;
    public GameObject next;
    public bool isOwner = false;
    public bool isIndie = false;
    public bool isSeller = false;
    public bool isRestaurant = false;
    private string myemail;
    public signuphandler userinfo;

    Firebase.Auth.FirebaseAuth auth;


    // Start is called before the first frame update
    void Start()
    {
        initialScene.SetActive(true);
        buyerScene1.SetActive(false);
        //userinfo = new signuphandler();
        userinfo = GameObject.Find("signuphandler").GetComponent<signuphandler>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void buyerButton()
    {
        buyerScene1.SetActive(true);
    }

    public void sellerButton()
    {
        isSeller = true;
    }

    public void businessOwner()
    {
        isOwner = true;
        BusinessOwner.SetActive(true);

        //myemail = userinfo.GetEmail();
        //  email = "inesss@ufl.edu";

        myemail = PlayerPrefs.GetString("email");


        FirebaseFirestore db = FirebaseFirestore.DefaultInstance;

        DocumentReference docRef = db.Collection("BusinessOwnerdata").Document(myemail);

        Dictionary<string, object> BusinessOwnerdata = new Dictionary<string, object>();
        docRef.SetAsync(BusinessOwnerdata).ContinueWithOnMainThread(task => {
            Debug.Log("Added data to the alovelace document in the users collection.");
        });


    }

    public void independent()
    {
        isIndie = true;
        SceneManager.LoadScene("VuforiaScene");
    }

    public void restaurant()
    {
        isRestaurant = true;
        produce.SetActive(true);
    }

    public void nextfunctiph()
    {
        isRestaurant = true;
        next.SetActive(true);
    }

    public void addProduce( string product)
        {

        FirebaseFirestore db = FirebaseFirestore.DefaultInstance;

        DocumentReference docRef = db.Collection("BusinessOwnerdata").Document(myemail);

        Dictionary<string, object> BusinessOwnerdata = new Dictionary<string, object>{
        { product, product },
        
};


        docRef.SetAsync(BusinessOwnerdata).ContinueWithOnMainThread(task => {
            Debug.Log("Added data to the alovelace document in the users collection.");
        });

    }

}
