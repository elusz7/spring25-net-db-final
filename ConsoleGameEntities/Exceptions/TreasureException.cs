﻿namespace ConsoleGameEntities.Exceptions;

public class TreasureException : Exception
{
    public TreasureException() :base() { }
    public TreasureException(string message) : base(message) { }
}
