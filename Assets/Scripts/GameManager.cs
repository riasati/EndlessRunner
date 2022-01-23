using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;



public class GameManager : MonoBehaviour
{
    public int runner;
    public GameObject mmd;
    public GameObject masoud;
    public GameObject kamran;
    public GameObject hooman;
    public GameObject controller;

    public int Coins;
    public GameObject loseMenu;
    public Text CoinsText;
    public GameObject Plane;
    public GameObject Barrier;
    public GameObject Coin;
    public bool Alive;

    // Start is called before the first frame update
    void Start()
    {
        characterID cid = new characterID();
        string pathJson = Application.streamingAssetsPath + "/cs.json";
        string cinfo = File.ReadAllText(pathJson);
        cid = JsonUtility.FromJson<characterID>(cinfo);
        runner = cid.id;
        //runner = 1;
        if (runner == 1)
        {
            GameObject x= Instantiate(mmd, new Vector3(0.07f, -6.163142f, -0.1208459f), new Quaternion(0f, 0f, 0f, 0f));
            x.transform.position = new Vector3(0.047f, 0.007f, -0.029f);
            
            x.transform.localScale = new Vector3(1.054079f, 1.054079f, 1.054079f);
            
            x.transform.parent = controller.transform;

            x.transform.rotation = new Quaternion(0f, -90f, 0f, 0f);
            x.transform.Rotate(0f,90f, 0f);
        }

        if (runner == 2)
        {
            GameObject x = Instantiate(masoud, new Vector3(0.07f, -6.163142f, -0.1208459f), new Quaternion(0f, 0f, 0f, 0f));
            x.transform.position = new Vector3(0.047f, 0.007f, -0.029f);

            x.transform.localScale = new Vector3(1.054079f, 1.054079f, 1.054079f);

            x.transform.parent = controller.transform;

            x.transform.rotation = new Quaternion(0f, -90f, 0f, 0f);
            x.transform.Rotate(0f, 90f, 0f);
        }

        if (runner == 3)
        {
            GameObject x = Instantiate(kamran, new Vector3(0.07f, -6.163142f, -0.1208459f), new Quaternion(0f, 0f, 0f, 0f));
            x.transform.position = new Vector3(0.047f, 0.007f, -0.029f);

            x.transform.localScale = new Vector3(1.054079f, 1.054079f, 1.054079f);

            x.transform.parent = controller.transform;

            x.transform.rotation = new Quaternion(0f, -90f, 0f, 0f);
            x.transform.Rotate(0f, 90f, 0f);
        }

        if (runner == 4)
        {
            GameObject x = Instantiate(hooman, new Vector3(0.07f, -6.163142f, -0.1208459f), new Quaternion(0f, 0f, 0f, 0f));
            x.transform.position = new Vector3(0.047f, 0.007f, -0.029f);

            x.transform.localScale = new Vector3(1.054079f, 1.054079f, 1.054079f);

            x.transform.parent = controller.transform;

            x.transform.rotation = new Quaternion(0f, -90f, 0f, 0f);
            x.transform.Rotate(0f, 90f, 0f);
        }
        Alive = true;
        CoinsText.text = "Coins: " + Coins.ToString();
        StartCoroutine(PlaneGenerator());
        StartCoroutine(BarrierGenerator());
        StartCoroutine(CoinGenerator());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lose()
    {
        Alive = false;
        loseMenu.SetActive(true);
        Debug.Log("Hit!!!");
    }

    public void getCoin()
    {
        Coins++;
        CoinsText.text = "Coins: " + Coins.ToString();
    }

    IEnumerator PlaneGenerator()
    {
        while (true)
        {
            if (Alive)
            {
                Instantiate(Plane, new Vector3(-127.9f, 0f, 0f), new Quaternion(0f, 0f, 0f, 0f));
                yield return new WaitForSeconds(17);
            }
        }
    }

    IEnumerator BarrierGenerator()
    {
        while (true)
        {
            if (Alive)
            {
                GameObject B = Instantiate(Barrier, new Vector3(-35.74f, 0.31f, Random.Range(-4, 4)), new Quaternion(0f, 0f, 0f, 0f));
                Destroy(B, 8);
                yield return new WaitForSeconds(2);
            }
        }
    }

    IEnumerator CoinGenerator()
    {
        
        while (true)
        {
            if (Alive)
            {
                GameObject B = Instantiate(Coin, new Vector3(-29.91f, 0.27f, Random.Range(-4, 4)), new Quaternion(0f, 0f, 0f, 0f));
                Destroy(B, 20);
                yield return new WaitForSeconds(Random.Range(4, 7));
            }
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene("GameScene");
    }

    class characterID
    {
        public int id;
    }
}

