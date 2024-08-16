// See https://aka.ms/new-console-template for more information
using Business.Context;
using DataAccess.Entities;
using Newtonsoft.Json;

string localData = File.ReadAllText("data.json");
var jsonData = JsonConvert.DeserializeObject<List<Device>>(localData);
foreach (var item in jsonData)
{
    var context = new AppDbContext();
    context.Devices.Add(item);
    context.SaveChanges();
}