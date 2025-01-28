using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trans : MonoBehaviour
{
    public static void GoBack()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        Debug.Log("Active scene: " + activeScene.name);
        //GameObject.Find(activeScene.name).SetActive(false);
    }
    public void ToInstr()
    {
        SceneManager.LoadScene("Instr");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void ToLevels()
    {
        SceneManager.LoadScene("Levels");
    }
    public void ToInstr4()
    {
        SceneManager.LoadScene("Instr4");
    }
    public void ToInstr2()
    {
        SceneManager.LoadScene("Instr2");
    }
    public void ToInstr3()
    {
        SceneManager.LoadScene("Instr3");
    }
    public void ToInstr1()
    {
        SceneManager.LoadScene("Instr1");
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("лемч");
    }
    public void ToNotebook()
    {
        SceneManager.LoadScene("Notebook");
    }
    public void BackToLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void BackToLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }
    public void Level5()
    {
        SceneManager.LoadScene("Level5");
    }
    public void Level6()
    {
        SceneManager.LoadScene("Level6");
    }
    public void Level7()
    {
        SceneManager.LoadScene("Level7");
    }
    public void Level8()
    {
        SceneManager.LoadScene("Level8");
    }
    public void Level9()
    {
        SceneManager.LoadScene("Level9");
    }
    public void Level10()
    {
        SceneManager.LoadScene("Level10");
    }
    public void Level11()
    {
        SceneManager.LoadScene("Level11");
    }
    public void Level12()
    {
        SceneManager.LoadScene("Level12");
    }
    public void Level13()
    {
        SceneManager.LoadScene("Level13");
    }
    public void Level14()
    {
        SceneManager.LoadScene("Level14");
    }
    public void Level15()
    {
        SceneManager.LoadScene("Level15");
    }
    public void Level16()
    {
        SceneManager.LoadScene("Level16");
    }
    public void Level17()
    {
        SceneManager.LoadScene("Level17");
    }
    public void Level18()
    {
        SceneManager.LoadScene("Level18");
    }
    public void Level19()
    {
        SceneManager.LoadScene("Level19");
    }
    public void Level20()
    {
        SceneManager.LoadScene("Level20");
    }
    public void Level21()
    {
        SceneManager.LoadScene("Level21");
    }
    public void Answer202()
    {
        SceneManager.LoadScene("Answer202");
    }
    public void Answer203()
    {
        SceneManager.LoadScene("Answer203");
    }
    public void Answer204()
    {
        SceneManager.LoadScene("Answer204");
    }
    public void Answer205()
    {
        SceneManager.LoadScene("Answer205");
    }
    public void Answer206()
    {
        SceneManager.LoadScene("Answer206");
    }
    public void Answer207()
    {
        SceneManager.LoadScene("Answer207");
    }
    public void ToCall()
    {
        SceneManager.LoadScene("Call");
    }
}
