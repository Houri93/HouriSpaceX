﻿using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Rockets;

public sealed class Rocket
{
    [JsonPropertyName("height")]
    public Height Height { get; set; }

    [JsonPropertyName("diameter")]
    public Diameter Diameter { get; set; }

    [JsonPropertyName("mass")]
    public Mass Mass { get; set; }

    [JsonPropertyName("first_stage")]
    public FirstStage FirstStage { get; set; }

    [JsonPropertyName("second_stage")]
    public SecondStage SecondStage { get; set; }

    [JsonPropertyName("engines")]
    public Engines Engines { get; set; }

    [JsonPropertyName("landing_legs")]
    public LandingLegs LandingLegs { get; set; }

    [JsonPropertyName("payload_weights")]
    public List<PayloadWeight> PayloadWeights { get; set; }

    [JsonPropertyName("flickr_images")]
    public List<string> FlickrImages { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonPropertyName("stages")]
    public int Stages { get; set; }

    [JsonPropertyName("boosters")]
    public int Boosters { get; set; }

    [JsonPropertyName("cost_per_launch")]
    public int CostPerLaunch { get; set; }

    [JsonPropertyName("success_rate_pct")]
    public int SuccessRatePct { get; set; }

    [JsonPropertyName("first_flight")]
    public string FirstFlight { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("company")]
    public string Company { get; set; }

    [JsonPropertyName("wikipedia")]
    public string Wikipedia { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

