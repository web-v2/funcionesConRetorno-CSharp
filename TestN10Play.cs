using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class TestN10_Play3DAnimal
{
    [SetUp]
    public void SetUp()
    {
        SceneManager.LoadScene("3DAnimal");
    }
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestN10PlayMode()
    {
        yield return new WaitForSeconds(7);
        Assert.AreEqual("3DAnimal", SceneManager.GetActiveScene().name);
    }
    [TearDown]
    public void TearDown()
    {
        SceneManager.UnloadSceneAsync("3DAnimal");
    }
}
