using MyApp.ServiceModel.Models;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.ServiceModel
{
    [Route("/updateuser")]
    [Route("/updateuser/{id}")]
    [Table("adress")]
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Address : IReturn<UpdateUserResponse>
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public Geo geo { get; set; }
    }
    [Table("company")]
    public class Company : IReturn<UpdateUserResponse>
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }
    [Table("Geo")]
    public class Geo : IReturn<UpdateUserResponse>
    {
        public Int32 lat { get; set; }
        public Int32 lng { get; set; }
    }

    [Table("user")]
    public class UpdateUser : IReturn<UpdateUserResponse>
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

   
}
    public class UpdateUserResponse : IReturn<UpdateUserResponse>
{
    public string Result { get; set; }
}