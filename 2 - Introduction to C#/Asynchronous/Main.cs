public async Task getDataAsync()
{
    // if the method returns void, the type is Task, otherwise use Task<T>, for example: Task<string>
    try
    {
        var data = await GetDataFromApi();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

public async Task getData()
{
    HttpClient httpClient = new HttpClient();
    try
    {
        var data = await httpClient.getDataNow();
        var data2 = await httpClient.getDataNow();
        Task.WhenAll(data, data2);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}