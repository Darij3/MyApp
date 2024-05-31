using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.ServiceModel.Models
{
    [Route("/user")]
    [Route("/user/{id}")]

    [Table("adress")]
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class Address : IReturn<UserResponse>
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public Geo geo { get; set; }
    }
    [Table("company")]
    public class Company:IReturn<UserResponse>
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }
    [Table("Geo")]
    public class Geo : IReturn<UserResponse> 
    {
        public Int32 lat { get; set; }
        public Int32 lng { get; set; }
    }

    [Table("user")]
    public class User : IReturn<UserResponse>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }
    }

    public class UserResponse
    {
        public string Result { get; set; }
    }
}