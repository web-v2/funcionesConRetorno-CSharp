using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Test9_SQL
{
    private SQLiteManager sql;
    [SetUp]
    public void Setup()
    {
        sql = new GameObject().AddComponent<SQLiteManager>();
    }
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestN9_SQLWithEnumeratorPasses()
    {
        //Act
        bool tableConceptosLibroExist = sql.TableExists("ConceptosLibro");
        bool tableEstudiantesExist = sql.TableExists("Estudiantes");
        bool tablePreguntasExist = sql.TableExists("Preguntas");
        bool tablePreguntasPreSaberExist = sql.TableExists("PreguntasPreSaber");
        bool tableSessionsExist = sql.TableExists("Sessions");
        bool tableTestsExist = sql.TableExists("Tests");        
        
        //Assert
        Assert.IsTrue(tableConceptosLibroExist);
        Assert.IsTrue(tableEstudiantesExist);
        Assert.IsTrue(tablePreguntasExist);
        Assert.IsTrue(tablePreguntasPreSaberExist);
        Assert.IsTrue(tableSessionsExist);
        Assert.IsTrue(tableTestsExist);
        yield return null;
    }
    [TearDown]
    public void TearDown()
    {
        Object.Destroy(sql);
    }
}
