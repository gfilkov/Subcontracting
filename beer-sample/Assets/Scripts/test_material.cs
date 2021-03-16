using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_material : MonoBehaviour
{
    GameObject cola;
    GameObject theBeer;
    GameObject beeer_ipa;
    GameObject beeer_lager;
    GameObject beeer_shocktop;

    Object[] beerLabels;

    // Start is called before the first frame update
    void Start()
    {
        cola = GameObject.Find("Cola Can");
        /*
        beeer_ipa = Instantiate(cola);
        beeer_lager = Instantiate(cola);
        beeer_shocktop = Instantiate(cola);

        // re-assign material
        Material[] mats0 = beeer_ipa.GetComponent<Renderer>().materials;
        mats0[0].mainTexture = Resources.Load("can_beer_ipa") as Texture;
        beeer_ipa.transform.Translate(4 * Vector3.right);

        Material[] mats1 = beeer_lager.GetComponent<Renderer>().materials;
        mats1[0].mainTexture = Resources.Load("can_beer_lager") as Texture;
        beeer_lager.transform.Translate(8 * Vector3.right);

        Material[] mats2 = beeer_shocktop.GetComponent<Renderer>().materials;
        mats2[0].mainTexture = Resources.Load("can_beer_shocktop") as Texture;
        beeer_shocktop.transform.Translate(12 * Vector3.right);
        */

        beerLabels = Resources.LoadAll("labels", typeof(Texture2D));
        for(int i = 0; i < beerLabels.Length; i++)
        {
            theBeer = Instantiate(cola);

            Material[] mats = theBeer.GetComponent<Renderer>().materials;
            Texture2D texture = (Texture2D)beerLabels[i];
            mats[0].mainTexture = texture;
            theBeer.transform.Translate(i*3 * Vector3.right);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
