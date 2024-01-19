using NUnit.Framework;
using UnityEngine;
public class Test8_LabManager
{
    private SQLiteManager sql;
    private NewBehaviourScript jugador;

    [SetUp]
    public void Setup()
    {        
        sql = new GameObject().AddComponent<SQLiteManager>();
        jugador = new GameObject().AddComponent<NewBehaviourScript>();
    }
    [Test]
    public void CheckTableExists_TableExists_ReturnsTrue()
    {
        bool result = sql.TableExists("Sessions");
        Assert.IsTrue(result);
    }
    [Test]
    public void CheckTableExists_TableDoesNotExist_ReturnsFalse()
    {
        bool result = sql.TableExists("NoExistSessions");
        Assert.IsFalse(result);
    }    
    [Test]
    public void lecturaJSON_off()
    {
       string respuesta = jugador.getSessionEstadoLab();
       Assert.AreEqual("OFF", respuesta);    
    }

    [Test]
    public void SesionExistUser()
    {       
        string respuesta = sql.userSessionExist(1099992459);
        Assert.AreEqual("true", respuesta);
    }
    [TearDown]
    public void TearDown()
    {
        Object.Destroy(sql);
        Object.Destroy(jugador);
    }
}
