﻿using System;
using System.Collections.Generic;

namespace efnew3.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FullName { get; set; }
}
