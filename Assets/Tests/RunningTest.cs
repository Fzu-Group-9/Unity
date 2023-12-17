using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RunningTest
{
    [UnitySetUp]
    public IEnumerator LoadScene()
    {
        yield return SceneManager.LoadSceneAsync("跑酷");
    }

    [UnityTest]
    public IEnumerator BackToTitle()
    {
        yield return new WaitForSeconds(1); // 等待1秒，确保场景加载完成

        GameObject buttonObject = GameObject.Find("返回"); 
        Button backButton = buttonObject.GetComponent<Button>();
        backButton.onClick.Invoke();

        yield return new WaitForSeconds(1); // 等待1秒，确保场景切换完成

        // 跳转到Title
        Assert.AreEqual("菜单界面", SceneManager.GetActiveScene().name);

    }

    [UnityTest]
    public IEnumerator TestRunnerModeButton()
    {
        yield return new WaitForSeconds(1); // 等待1秒，确保场景加载完成

        GameObject buttonObject4 = GameObject.Find("继续"); 
        Button Button4 = buttonObject4.GetComponent<Button>();
        Button4.onClick.Invoke();

        yield return new WaitForSeconds(1); // 等待1秒，确保场景切换完成

        // 跳转到RUNNING
        Assert.AreEqual("RUNNING", SceneManager.GetActiveScene().name);         
    }
}
  