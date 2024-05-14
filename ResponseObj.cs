using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("id")]
    public int id { get; set; }

    [JsonProperty("appId")]
    public string appId { get; set; }

    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("description")]
    public string description { get; set; }

    [JsonProperty("icon")]
    public string icon { get; set; }

    [JsonProperty("genres")]
    public string[] genres { get; set; }

    [JsonProperty("genreIds")]
    public string[] genreIds { get; set; }

    [JsonProperty("primaryGenre")]
    public string primaryGenre { get; set; }

    [JsonProperty("primaryGenreId")]
    public int primaryGenreId { get; set; }

    [JsonProperty("contentRating")]
    public string contentRating { get; set; }

    [JsonProperty("languages")]
    public string[] languages { get; set; }

    [JsonProperty("size")]
    public string size { get; set; }

    [JsonProperty("requiredOsVersion")]
    public string requiredOsVersion { get; set; }

    [JsonProperty("released")]
    public DateTime released { get; set; }

    [JsonProperty("updated")]
    public DateTime updated { get; set; }

    [JsonProperty("version")]
    public string version { get; set; }

    [JsonProperty("price")]
    public int price { get; set; }

    [JsonProperty("currency")]
    public string currency { get; set; }

    [JsonProperty("free")]
    public bool free { get; set; }

    [JsonProperty("developerId")]
    public int developerId { get; set; }

    [JsonProperty("developer")]
    public string developer { get; set; }

    [JsonProperty("developerUrl")]
    public string developerUrl { get; set; }

    [JsonProperty("developerWebsite")]
    public string developerWebsite { get; set; }

    [JsonProperty("score")]
    public double score { get; set; }

    [JsonProperty("reviews")]
    public int reviews { get; set; }

    [JsonProperty("currentVersionScore")]
    public double currentVersionScore { get; set; }

    [JsonProperty("currentVersionReviews")]
    public int currentVersionReviews { get; set; }

    [JsonProperty("screenshots")]
    public string[] screenshots { get; set; }

    [JsonProperty("ipadScreenshots")]
    public string[] ipadScreenshots { get; set; }

    [JsonProperty("appletvScreenshots")]
    public object[] appletvScreenshots { get; set; }

    [JsonProperty("supportedDevices")]
    public string[] supportedDevices { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
