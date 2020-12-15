using System;

public enum Rating { Good, Great, Excellent };
public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string dName, float dAge, string dOwner, Rating dRating)
    {
        name = dName;
        age = dAge;
        owner = dOwner;
        rating = dRating;
    }
}
