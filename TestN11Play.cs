using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class TestN11_Play3DVegetal
{
    [SetUp]
    public void SetUp()
    {
        SceneManager.LoadScene("3DVegetal");
    }
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestN11PlayMode()
    {
        yield return new WaitForSeconds(7);
        Assert.AreEqual("3DVegetal", SceneManager.GetActiveScene().name);
    }
    [TearDown]
    public void TearDown()
    {
        SceneManager.UnloadSceneAsync("3DVegetal");
    }
}
