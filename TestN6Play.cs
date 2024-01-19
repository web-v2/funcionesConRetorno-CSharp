using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class Test6_PlayQuestions
{

    [SetUp]
    public void SetUp()
    {        
        SceneManager.LoadScene("Questions");
    }
    
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator Test6PlayWithEnumeratorPasses()
    {     
        LevelManager level = new LevelManager();      
        level.btnQuiz();        
        LogAssert.Expect(LogType.Log, "Botón presionado en el menú rumbo al questionario");        
        yield return new WaitForSeconds(3);        
        Assert.AreEqual("Questions", SceneManager.GetActiveScene().name);
    }

    [TearDown]
    public void TearDown()
    {        
        SceneManager.UnloadSceneAsync("Questions");
    }
}
