using System;
using System.Collections.Generic;

namespace CRUDPOC.Models;

public partial class State
{
    public long Id { get; set; }

    public long? CountryId { get; set; }

    public string? State1 { get; set; }
}
