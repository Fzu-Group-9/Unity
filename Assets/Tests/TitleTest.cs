using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleTest
{
    [UnitySetUp]
    public IEnumerator LoadScene()
    {
        yield return SceneManager.LoadSceneAsync("菜单界面");
    }

    [UnityTest]
    public IEnumerator TestAdventureModeButton()
    {
        yield return new WaitForSeconds(1); // 等待1秒，确保场景加载完成

        GameObject buttonObject = GameObject.Find("冒险模式"); 
        Button adventureButton = buttonObject.GetComponent<Button>();
        adventureButton.onClick.Invoke();

        yield return new WaitForSeconds(1); // 等待1秒，确保场景切换完成

        // 跳转故事背景
        Assert.AreEqual("故事背景", SceneManager.GetActiveScene().name); 

        GameObject buttonObject2 = GameObject.Find("继续"); 
        Button Button2 = buttonObject2.GetComponent<Button>();
        Button2.onClick.Invoke();

        yield return new WaitForSeconds(1); // 等待1秒，确保场景切换完成

        // 跳转冒险
        Assert.AreEqual("冒险", SceneManager.GetActiveScene().name); 

        GameObject buttonObject3 = GameObject.Find("继续"); 
        Button Button3 = buttonObject3.GetComponent<Button>();
        Button3.onClick.Invoke();

        yield return new WaitForSeconds(1); // 等待1秒，确保场景切换完成     

        // 跳转关卡选择
        Assert.AreEqual("关卡选择", SceneManager.GetActiveScene().name); 
    }

    [UnityTest]
    public IEnumerator TestRunnerModeButton()
    {
        yield return new WaitForSeconds(1); // 等待1秒，确保场景加载完成

        GameObject buttonObject = GameObject.Find("跑酷模式"); 
        Button adventureButton = buttonObject.GetComponent<Button>();
        adventureButton.onClick.Invoke();

        yield return new WaitForSeconds(1); // 等待1秒，确保场景切换完成

        // 跳转到跑酷模式
        Assert.AreEqual("跑酷", SceneManager.GetActiveScene().name); 

        // GameObject buttonObject4 = GameObject.Find("继续"); 
        // Button Button4 = buttonObject4.GetComponent<Button>();
        // Button4.onClick.Invoke();

        // yield return new WaitForSeconds(1); // 等待1秒，确保场景切换完成

        // // 跳转到RUNNING
        // Assert.AreEqual("RUNNING", SceneManager.GetActiveScene().name);         
    }
}