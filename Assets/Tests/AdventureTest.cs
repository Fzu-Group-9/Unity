using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AdventureTest
{
    [UnitySetUp]
    public IEnumerator LoadScene()
    {
        yield return SceneManager.LoadSceneAsync("关卡选择");
    }

    [UnityTest]
    public IEnumerator BackToTitle()
    {
        yield return new WaitForSeconds(1); // 等待1秒，确保场景加载完成

        GameObject buttonObject = GameObject.Find("返回"); 
        Button adventureButton = buttonObject.GetComponent<Button>();
        adventureButton.onClick.Invoke();

        yield return new WaitForSeconds(1); // 等待1秒，确保场景切换完成

        // 跳转冒险
        Assert.AreEqual("冒险", SceneManager.GetActiveScene().name); 

        GameObject buttonObject2 = GameObject.Find("返回"); 
        Button Button2 = buttonObject2.GetComponent<Button>();
        Button2.onClick.Invoke();

        yield return new WaitForSeconds(1); // 等待1秒，确保场景切换完成

        // 跳转菜单界面
        Assert.AreEqual("菜单界面", SceneManager.GetActiveScene().name); 
    }

    [UnityTest]
    public IEnumerator RunForest()
    {
        yield return new WaitForSeconds(1); // 等待1秒，确保场景加载完成

        GameObject buttonObject = GameObject.Find("Forest"); 
        Button adventureButton = buttonObject.GetComponent<Button>();
        adventureButton.onClick.Invoke();

        yield return new WaitForSeconds(1); // 等待1秒，确保场景切换完成

        // 跳转到Forest
        Assert.AreEqual("Forest", SceneManager.GetActiveScene().name); 
    }

    [UnityTest]
    public IEnumerator RunCave()
    {
        yield return new WaitForSeconds(1); // 等待1秒，确保场景加载完成

        GameObject buttonObject = GameObject.Find("Cave"); 
        Button adventureButton = buttonObject.GetComponent<Button>();
        adventureButton.onClick.Invoke();

        yield return new WaitForSeconds(1); // 等待1秒，确保场景切换完成

        // 跳转到Cave
        Assert.AreEqual("Cave", SceneManager.GetActiveScene().name); 
    }
    [UnityTest]
    public IEnumerator RunHill()
    {
        yield return new WaitForSeconds(1); // 等待1秒，确保场景加载完成

        GameObject buttonObject = GameObject.Find("Hill"); 
        Button adventureButton = buttonObject.GetComponent<Button>();
        adventureButton.onClick.Invoke();

        yield return new WaitForSeconds(1); // 等待1秒，确保场景切换完成

        // 跳转到Hill
        Assert.AreEqual("Hill", SceneManager.GetActiveScene().name); 
    }



}