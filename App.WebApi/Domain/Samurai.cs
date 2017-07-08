using System;
using System.Collections.Generic;

namespace SamuraiApp.Domain {
  public class Samurai {

    public Samurai () {
      Quotes = new List<Quote> ();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public Entrance Entrance { get; set; }
    public List<Quote> Quotes { get; set; }

    public void CreateEntrance (int minute, string sceneName, string description) {
      Entrance = new Entrance (minute, sceneName, description);
    }

    //creating a simple, public property for the owned entity
   // public PersonName SecretIdentity {get;set;}

#if true //this is my real code and tests ok with inmemory
    private PersonName _secretIdentity;
    private PersonName SecretIdentity { get; set; }
    public string RevealSecretIdentity () {
      if (_secretIdentity == null) {
        return "It's a secret";
      } else {
        return _secretIdentity.FullName ();
      }
    }
    public void Identify (string first, string last) {
      _secretIdentity = PersonName.Create (first, last);
    }
    #endif
  }
}