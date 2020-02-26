using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();         //Fields  //private List<T> but any thing in this class can get to it even though it is private.
        public static IEnumerable<GuestResponse> Responses                                  //Properties   //public property to {get}
        {
            get
            { return responses; }
        }
        public static void AddResponse(GuestResponse response)                              //Methods      //public Add() method
        {
            responses.Add(response);
        }
    }
}
