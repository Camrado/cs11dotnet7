﻿namespace Packt.Shared;

// this file simulates an autogenerated class

public partial class Person {
    // a readonly property defined using C# 1-5 syntax
    public string Origin {
        get {
            return $"{Name} was born on {HomePlanet}";
        }
    }
    
    // two readonly properties defined using C# 6+ lambda expression body syntax
    public string Greeting => $"{Name} says 'Hello!'";
    public int Age => DateTime.Today.Year - DateOfBirth.Year;
    
    // a read-write property defined using C# 3.0 syntax
    public string? FavouriteIceCream { get; set; } // auto-syntax. Although you have not manually created a field to store the person's favourite ice cream, it is there, automatically created by the compiler for you.
    
    // a private field to store the property value
    private string? favouritePrimaryColor;
    
    // a public property to read and write to the field
    public string? FavouritePrimaryColor {
        get => favouritePrimaryColor;
        set {
            switch (value?.ToLower()) {
                case "red": 
                case "green":
                case "blue":
                    favouritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException($"{value} is not a primary color. Choose from: red, green, blue.");
            }
        }
    }
    
    // indexers
    public Person this[int index] {
        get => Children[index]; // pass on to the List<Person> indexer
        set => Children[index] = value;
    }
    public Person this[string name] {
        get => Children.Find(p => p.Name == name);
        set {
            Person found = Children.Find(p => p.Name == name);
            if (found is not null) {
                found = value;
            }
        }
    }

    private bool married = false;
    public bool Married => married;

    private Person? spouse = null;
    public Person? Spouse => spouse;
    
    // static method to marry
    public static void Marry(Person p1, Person p2) {
        p1.Marry(p2);
    }
    
    // instance method to marry
    public void Marry(Person partner) {
        if (Married) return;
        spouse = partner;
        married = true;
        partner.Marry(this);
    }
    
    // operator to "marry"
    public static bool operator +(Person p1, Person p2) {
        Marry(p1, p2);
        return p1.Married && p2.Married; // confirm they are both now married
    }
    
    // static method to "multiply"
    public static Person Procreate(Person p1, Person p2) {
        if (p1.Spouse != p2) {
            throw new ArgumentException("You must be married to procreate.");
        }

        Person baby = new() {
            Name = $"Baby of {p1.Name} and {p2.Name}",
            DateOfBirth = DateTime.Now
        };
        
        p1.Children.Add(baby);
        p2.Children.Add(baby);

        return baby;
    }
    
    // instance method to "multiply"
    public Person ProcreateWith(Person partner) {
        return Procreate(this, partner);
    }
    
    // operator to "multiply"
    public static Person operator *(Person p1, Person p2) {
        return Procreate(p1, p2);
    }
}