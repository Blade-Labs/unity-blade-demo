using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BladeLabs.UnitySDK;

public class script1 : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        BladeSDK bladeSdk = new BladeSDK("Rww3x27z3Q9rrIvRQ6qGgIRppxz5e5HHPWdARyxnMXpe77WD5MW39REBXXvRZsZE", BladeLabs.UnitySDK.Network.Testnet, "unitysdktest", SdkEnvironment.CI);

            // get info
        Debug.Log(await bladeSdk.getInfo());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
