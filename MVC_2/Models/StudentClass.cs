using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_2.Models
{
    public class StudentClass
    {
        public int StId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public bool IsStudent { get; set; }
        public skills Skills { get; set; }   
        public Qualification Qualification { get; set; }
    }
    public enum skills
    {
        Teamplayer,
        Hardworker,
        Creative
    }
    public enum Qualification
    {
        BE,
        BTech,
        ME,
        MTech
    }
}