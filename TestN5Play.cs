using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class Test5_PlayOpeningLab
{
    [SetUp]
    public void SetUp()
    {        
        SceneManager.LoadScene("Open1");
    }
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestN5_PlayMode()
    {        
        yield return new WaitForSeconds(12);        
        Assert.AreEqual("Lab", SceneManager.GetActiveScene().name);
    }
    [TearDown]
    public void TearDown()
    {        
        SceneManager.UnloadSceneAsync("Lab");
    }
}
