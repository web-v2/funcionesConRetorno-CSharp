using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class TestN12_Play3DProcariota
{
    [SetUp]
    public void SetUp()
    {
        SceneManager.LoadScene("3DProcariota");
    }
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestN12PlayMode()
    {
        yield return new WaitForSeconds(7);
        Assert.AreEqual("3DProcariota", SceneManager.GetActiveScene().name);
    }
    [TearDown]
    public void TearDown()
    {
        SceneManager.UnloadSceneAsync("3DProcariota");
    }
}
