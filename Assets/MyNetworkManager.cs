using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

   
    // Use this for initialization
    void Start () {
   
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MyStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " staring host");
        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad +  " host started");
        Debug.Log("started");
    }

    public override void OnStartClient(NetworkClient client)
    {
        base.OnStartClient(client);

        Debug.Log(Time.timeSinceLevelLoad + " client start requested");
        InvokeRepeating("PrintDots", 0f, 1f);

    }

    

    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnStartClient(client);

        Debug.Log(Time.timeSinceLevelLoad + " client connecting to ip: " + conn.address);
        CancelInvoke();
       

    }

    void PrintDots()
    {
        Debug.Log(".");
    }

}
