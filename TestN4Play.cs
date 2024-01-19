using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class Test4_PlayLab
{
    [SetUp]
    public void SetUp()
    {
        SceneManager.LoadScene("Lab");
    }
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestN4PlayMode()
    {        
        yield return new WaitForSeconds(5);
        Assert.AreEqual("Lab", SceneManager.GetActiveScene().name);
    }
    [TearDown]
    public void TearDown()
    {
        SceneManager.UnloadSceneAsync("Lab");
    }
}
