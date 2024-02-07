using System.Text.Json.Serialization;

namespace SpaceXData.ApiClient.Starlink;

public sealed class SpaceTrack
{
    [JsonPropertyName("CCSDS_OMM_VERS")]
    public string CCSDSOMMVERS { get; set; }

    [JsonPropertyName("COMMENT")]
    public string COMMENT { get; set; }

    [JsonPropertyName("CREATION_DATE")]
    public string CREATIONDATE { get; set; }

    [JsonPropertyName("ORIGINATOR")]
    public string ORIGINATOR { get; set; }

    [JsonPropertyName("OBJECT_NAME")]
    public string OBJECTNAME { get; set; }

    [JsonPropertyName("OBJECT_ID")]
    public string OBJECTID { get; set; }

    [JsonPropertyName("CENTER_NAME")]
    public string CENTERNAME { get; set; }

    [JsonPropertyName("REF_FRAME")]
    public string REFFRAME { get; set; }

    [JsonPropertyName("TIME_SYSTEM")]
    public string TIMESYSTEM { get; set; }

    [JsonPropertyName("MEAN_ELEMENT_THEORY")]
    public string MEANELEMENTTHEORY { get; set; }

    [JsonPropertyName("EPOCH")]
    public string EPOCH { get; set; }

    [JsonPropertyName("MEAN_MOTION")]
    public double MEANMOTION { get; set; }

    [JsonPropertyName("ECCENTRICITY")]
    public double ECCENTRICITY { get; set; }

    [JsonPropertyName("INCLINATION")]
    public double INCLINATION { get; set; }

    [JsonPropertyName("RA_OF_ASC_NODE")]
    public double RAOFASCNODE { get; set; }

    [JsonPropertyName("ARG_OF_PERICENTER")]
    public double ARGOFPERICENTER { get; set; }

    [JsonPropertyName("MEAN_ANOMALY")]
    public double MEANANOMALY { get; set; }

    [JsonPropertyName("EPHEMERIS_TYPE")]
    public int EPHEMERISTYPE { get; set; }

    [JsonPropertyName("CLASSIFICATION_TYPE")]
    public string CLASSIFICATIONTYPE { get; set; }

    [JsonPropertyName("NORAD_CAT_ID")]
    public int NORADCATID { get; set; }

    [JsonPropertyName("ELEMENT_SET_NO")]
    public int ELEMENTSETNO { get; set; }

    [JsonPropertyName("REV_AT_EPOCH")]
    public int REVATEPOCH { get; set; }

    [JsonPropertyName("BSTAR")]
    public double BSTAR { get; set; }

    [JsonPropertyName("MEAN_MOTION_DOT")]
    public double MEANMOTIONDOT { get; set; }

    [JsonPropertyName("MEAN_MOTION_DDOT")]
    public double MEANMOTIONDDOT { get; set; }

    [JsonPropertyName("SEMIMAJOR_AXIS")]
    public double SEMIMAJORAXIS { get; set; }

    [JsonPropertyName("PERIOD")]
    public double PERIOD { get; set; }

    [JsonPropertyName("APOAPSIS")]
    public double APOAPSIS { get; set; }

    [JsonPropertyName("PERIAPSIS")]
    public double PERIAPSIS { get; set; }

    [JsonPropertyName("OBJECT_TYPE")]
    public string OBJECTTYPE { get; set; }

    [JsonPropertyName("RCS_SIZE")]
    public object RCSSIZE { get; set; }

    [JsonPropertyName("COUNTRY_CODE")]
    public string COUNTRYCODE { get; set; }

    [JsonPropertyName("LAUNCH_DATE")]
    public string LAUNCHDATE { get; set; }

    [JsonPropertyName("SITE")]
    public string SITE { get; set; }

    [JsonPropertyName("DECAY_DATE")]
    public object DECAYDATE { get; set; }

    [JsonPropertyName("DECAYED")]
    public int DECAYED { get; set; }

    [JsonPropertyName("FILE")]
    public int FILE { get; set; }

    [JsonPropertyName("GP_ID")]
    public int GPID { get; set; }

    [JsonPropertyName("TLE_LINE0")]
    public string TLELINE0 { get; set; }

    [JsonPropertyName("TLE_LINE1")]
    public string TLELINE1 { get; set; }

    [JsonPropertyName("TLE_LINE2")]
    public string TLELINE2 { get; set; }
}


