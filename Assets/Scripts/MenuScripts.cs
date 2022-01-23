using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void goToAboutUs()
    {
        SceneManager.LoadScene("AboutUs");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void goToCC()
    {
        SceneManager.LoadScene("selectChar");
    }

    public void playMmd()
    {
        string pathJson = Application.streamingAssetsPath + "/cs.json";
        characterID cid = new characterID();
        cid.id = 1;
        string sch = JsonUtility.ToJson(cid);
        File.WriteAllText(pathJson, sch);
        SceneManager.LoadScene("GameScene");
    }

    public void playMasoud()
    {
        string pathJson = Application.streamingAssetsPath + "/cs.json";
        characterID cid = new characterID();
        cid.id = 2;
        string sch = JsonUtility.ToJson(cid);
        File.WriteAllText(pathJson, sch);
        SceneManager.LoadScene("GameScene");
    }

    public void playKamran()
    {
        string pathJson = Application.streamingAssetsPath + "/cs.json";
        characterID cid = new characterID();
        cid.id = 3;
        string sch = JsonUtility.ToJson(cid);
        File.WriteAllText(pathJson, sch);
        SceneManager.LoadScene("GameScene");
    }

    public void playHooman()
    {
        string pathJson = Application.streamingAssetsPath + "/cs.json";
        characterID cid = new characterID();
        cid.id = 4;
        string sch = JsonUtility.ToJson(cid);
        File.WriteAllText(pathJson, sch);
        SceneManager.LoadScene("GameScene");
    }
    class characterID
    {
        public int id;
    }
}
