using RestSharp;
using Newtonsoft.Json;

namespace DragonArchiver.Core.Model;

// TODO: Implement api calls aimed at populating a list of Item's for us to view.
public class Open5EApiClient
{
    private readonly RestClient _client;

    public Open5EApiClient()
    {
        // We are using the open5e api to get ourselves data from the SRD
        _client = new RestClient(" https://api.open5e.com/");

    }

    
}