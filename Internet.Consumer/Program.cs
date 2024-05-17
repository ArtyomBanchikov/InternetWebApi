using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;
using System.Net.Http.Json;

HttpClient Client;
var handler = new HttpClientHandler();
handler.ClientCertificateOptions = ClientCertificateOption.Manual;
handler.ServerCertificateCustomValidationCallback =
    (httpRequestMessage, cert, cetChain, policyErrors) =>
    {
        return true;
    };
Client = new HttpClient(handler);
Client.BaseAddress = new Uri("");

var factory = new ConnectionFactory
{

};
using var _connection = factory.CreateConnection();
using var channel2 = _connection.CreateModel();
using var channel1 = _connection.CreateModel();

channel2.QueueDeclare(queue: "", autoDelete: false, durable: true, exclusive: false, arguments: null);
channel1.QueueDeclare(queue: "", autoDelete: false, durable: false, exclusive: false, arguments: null);

var consumer2 = new EventingBasicConsumer(channel2);
var consumer1 = new EventingBasicConsumer(channel1);

consumer1.Received += async (model, eventArgs) =>
{
    var body = eventArgs.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    try
    {
        AccountModel? account = JsonSerializer.Deserialize<AccountModel>(message);
        if (account != null)
        {
            await Client.PutAsJsonAsync("/account", account);
        }
    }
    catch
    {

    }
    Console.WriteLine(message);
};
consumer2.Received += async (model, eventArgs) =>
{
    var body = eventArgs.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    try
    {
        AccountModel? account = JsonSerializer.Deserialize<AccountModel>(message);
        if (account != null)
        {
            await Client.PutAsJsonAsync("/account", account);
        }
    }
    catch
    {

    }
    Console.WriteLine(message);
};

channel2.BasicConsume(queue: "",
    autoAck: true,
    consumer: consumer2);

channel1.BasicConsume(queue: "",
    autoAck: true,
    consumer: consumer1);


string input;
do
{
    input = Console.ReadLine();
} while (input != "stop");
public class AccountModel
{
    public int Id { get; set; }

    public double Balance { get; set; }
}