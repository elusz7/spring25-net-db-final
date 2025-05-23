﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGameEntities.Models.Entities;

namespace ConsoleGameEntities.Interfaces;

public interface IRoom
{
    int Id { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    Room? North { get; set; }
    Room? South { get; set; }
    Room? West { get; set; }
    Room? East { get; set; }
}
