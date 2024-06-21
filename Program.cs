using MongoDB.Bson.IO;
using MongoDB.Driver;
using omsMongoConsole;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

//obtener coleccion de la base de datos
var ordenCollection = obtenerColeccionOrden();

ordenRequest datosOrdenRequest = new ordenRequest(ordenCollection);

//obtener una orden especifica
//datosOrdenRequest.commercial_id = "OMAR123123";
//mostrarOrden(datosOrdenRequest);
//demo


//obtener todas las ordenes
//datosOrdenRequest.commercial_id = string.Empty;
//mostrarOrdenes(datosOrdenRequest);


//obtener ordenes por estado
//datosOrdenRequest.order_state = "WAITING_ACCEPTANCEs";
//mostrarOrdenXEstado(datosOrdenRequest);

//crear una nueva orden
crearOrden(datosOrdenRequest);

//actualizar el estado de una orden existente
//datosOrdenRequest.new_order_state = "PAGADO";
//datosOrdenRequest.commercial_id = "OMAR_2024-05-21-145Iaaaa";
//actualizaOrdene(datosOrdenRequest);
Console.ReadLine();

void mostrarOrdenes(ordenRequest datosOrden)
{
    List<orden> lsOrdenes = datosOrden.coleccionDB.Find(d => true).ToList();

    for (int i = 0; i < lsOrdenes.Count; i++)
    {
        Console.WriteLine(lsOrdenes[i].commercial_id);
    }
}
void mostrarOrden(ordenRequest datosOrden)
{
    //listar orden por id
    List<orden> lsOrdenes = datosOrden.coleccionDB.Find(d => d.commercial_id == datosOrden.commercial_id && d.order_state == d.order_state).ToList();

    if (lsOrdenes.Count == 1)
    {
        Console.WriteLine(lsOrdenes[0].commercial_id);
    }
    else
    {
        Console.WriteLine("no se encontro la orden.");
    }
    
}
List<orden> obtenerOrden(ordenRequest datosOrden)
{
    orden ordenEncontrada = new orden();

    //listar orden por id
    List<orden> lsOrdenes = datosOrden.coleccionDB.Find(d => d.commercial_id == datosOrden.commercial_id).ToList();    

    return lsOrdenes;
}
void mostrarOrdenXEstado(ordenRequest datosOrden)
{
    //listar orden por estado
    List<orden> lsOrdenes = datosOrden.coleccionDB.Find(d => d.order_state == datosOrden.order_state).ToList();

    if (lsOrdenes.Count > 0)
    {

        for (int i = 0; i < lsOrdenes.Count; i++)
        {
            Console.WriteLine(lsOrdenes[i].commercial_id);
        }
       
    }
    else
    {
        Console.WriteLine("no se encontro la orden.");
    }

}
IMongoCollection<orden> obtenerColeccionOrden()
{
    var client = new MongoClient("mongodb://3.19.216.130:27017");   

    var database = client.GetDatabase("demo");

    var ordenCollection = database.GetCollection<orden>("orden");

    return ordenCollection;
}
void crearOrden(ordenRequest datosOrden)
{
    string jsonOrigen = File.ReadAllText(@"dataOrden.json");

    orden nuevaOrden = Newtonsoft.Json.JsonConvert.DeserializeObject<orden>(jsonOrigen);

    try
    {
        datosOrden.coleccionDB.InsertOne(nuevaOrden);
        Console.WriteLine("Orden creada con exito.");
    }
    catch (MongoException ex)
    {

        throw ex;
    }
}
void actualizaOrdenReplace(ordenRequest datosOrden)
{
    List<orden> lsOrdenes = new List<orden>();

    //se busca la orden para poder actualizar la correcta
    lsOrdenes = obtenerOrden(datosOrden);

    if (lsOrdenes.Count == 1)
    {
        //se realiza el update de todo el json encontrado
        datosOrden.coleccionDB.ReplaceOne(d => d.commercial_id == datosOrden.commercial_id, datosOrden.myOrder);
    }
}
void actualizaOrdene(ordenRequest datosOrden)
{
    List<orden> lsOrdenes = new List<orden>();

    //primero se filtra el registro que queremos actualizar
    var filter = Builders<orden>.Filter.Eq("commercial_id", datosOrden.commercial_id);

    //se asigna el nuevo valor a la propiedad que deseamos actualizar
    var update = Builders<orden>.Update.Set("commercial_id", datosOrden.new_order_state);


    try
    {
        //se realiza el update
        datosOrden.coleccionDB.UpdateOne(filter, update);

        Console.WriteLine("Orden actualizada.");
    }
    catch (MongoException)
    {

        throw;
    }    

}