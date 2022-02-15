﻿
var dataSourceUrl = "https://example.com/source";
var carNamesPostUrl = "https://example.com/sink";
var carColorsPostUrl = "https://example.com/sink";
var httpClient = new HttpClient();

// TODO: use httpClient to GET Manufacturer data from the dataSourceUrl

//
// TODO: use httpClient to POST a list of unique car names offered by Ford, sorted in alphabetical order, to the carNamesPostUrl
// the POST body should be a JSON object { "names": [...] }

// TODO: use httpClient to POST a list of unique unique car colors offered by Chevy, sorted in alphabetical order, to the carColorsPostUrl
// the POST body should be a JSON object { "colors": [...] }

class Manufacturer
{
    public string Name { get; set; } = null!;
    public List<Car> Cars { get; set; } = new();
}

class Car
{
    public string Name { get; set; } = null!;
    public List<string> Colors { get; set; } = new();
}